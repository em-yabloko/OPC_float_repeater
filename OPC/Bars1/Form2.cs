using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Bars1
{
    public partial class Form2 : Form
    {
        public delegate void ButtonAddRow();
        public event ButtonAddRow re_ev;

        public delegate void RowDelete();
        public event RowDelete delete_ev;               

        public Form2()
        {
            InitializeComponent();
            re_ev += new ButtonAddRow(Adder_rows);
            Btn_add.Del_re = re_ev;

            delete_ev += new RowDelete(Scan_del_id);
            Row_else.Del_delete = delete_ev;

            // X
            iks.MouseEnter += (s, a) =>
            { iks.ForeColor = Color.Red; };

            iks.MouseLeave += (s, a) =>
            { iks.ForeColor = Color.Indigo; };

            iks.MouseClick += (s, a) =>
            {
                this.Close();
                this.Dispose();
            };

            // minus
            mini.MouseEnter += (s, a) =>
            { mini.ForeColor = Color.LightSkyBlue; };

            mini.MouseLeave += (s, a) =>
            { mini.ForeColor = Color.Indigo; };

            mini.MouseClick += (s, a) =>
            { this.WindowState = FormWindowState.Minimized; };

            // switch between com & tcp
            label_com.Show();
            label_tcp.Hide();

            // control of tcp
            Switch_tcp sw_tcp_example = new Switch_tcp();
            sw_tcp_example.Size = new Size(245, 75);
            sw_tcp_example.Location = new Point(15, 227);
            sw_tcp_example.Hide();
            Controls.Add(sw_tcp_example);
            sw_tcp_example.BringToFront();

            com_tcp.CheckedChanged += (s, a) =>
            {
                ad = false;

                if (com_tcp.Checked)
                {
                    label_com.Show();
                    label_tcp.Hide();

                    sw_tcp_example.Hide();
                }
                else
                {
                    label_com.Hide();
                    label_tcp.Show();

                    sw_tcp_example.Show();
                }
            };

            label_com.Click += (s, a) => { com_tcp.Checked = false; };
            label_tcp.Click += (s, a) => { com_tcp.Checked = true; };

        }

        // method the shift-delete
        public async void Scan_del_id()
        {
            await Task.Run(() =>
            {
                // cyclic scanning of the index positions
                for (int posDel = 0; posDel < rowsList.Length; posDel++)
                {   // if position consist and deleted
                    if ((rowsList[posDel] != null) && (rowsList[posDel].IsDisposed))
                    {
                        int posDel1 = posDel;
                        int bufferOfArray = rowsList.Length;
                        // do until rest positions runs out
                        while (((8 - (posDel1 + 1)) >= 0) & (posDel1 < 8))
                        {
                            if (posDel1 < 7)
                            {
                                if (rowsList[posDel1 + 1] != null)
                                {
                                    rowsList[posDel1] = rowsList[posDel1 + 1];
                                    Pointt(posDel1);
                                }
                                else
                                {
                                    rowsList[posDel1] = null;
                                }
                            }
                            else if (posDel1 == 7)
                                rowsList[posDel1] = null;
                            posDel1++;
                        }
                    }
                }
                // moving button up
                if (Ywas_added)
                {
                    Ywas_added = false;
                    plusY -= 48;
                }
                plusY -= 48;
                Button_loc(plusY);

                // moving button down
                Ywas_deleted = true;

                // shift generating start position of rows after delete
                --iAdd;

                Invoke((Action)(() => { btn_add2.Show(); }));

            });
        }

        // AllowDrop
        private bool _ad;
        public bool ad
        {
            get { return _ad; }
            set
            {
                _ad = value;
                if (_ad)
                {
                    this.cb1.AllowDrop = false;
                }
                else
                {
                    this.cb1.AllowDrop = true;
                }
            }
        }

        // define location of shifted row
        private void Pointt(int posDel1)
        {
                Invoke((Action)(() =>
                {
                    if (rowsList[posDel1] != null)
                    rowsList[posDel1].Location = new Point(274, 55 + 48 * posDel1);
                }));
        }

        // define location of shifted button
        private void Button_loc(int y)
        {
            Invoke((Action)(() =>
            {
                btn_add2.Size = new Size(120, 55);
                btn_add2.Location = new Point(515, y);
            }));            
        }

        bool com_cond = false;  // condition of connection to COM
        bool is_clicked = false;
        Message_types Mt = new Message_types();

            bool com_cond2 = false;  // condition of connection to COM
            bool is_clicked2 = false;
            Message_types Mt2 = new Message_types();
            Message_types Mt3 = new Message_types();

        public void Data_exchange2()
        {
            // COM2-port properties
            serialPort2.BaudRate = 9600;
            serialPort2.Parity = Parity.None;
            serialPort2.StopBits = StopBits.One;
            serialPort2.DataBits = 8;
            serialPort2.Handshake = Handshake.None;

            // set the read/write timeouts
            serialPort2.ReadTimeout = 1000;
            serialPort2.WriteTimeout = 1000;

            // exchange
            serialPort2.Open();
        }

        public void Data_exchange()
        {
            // COM-port properties
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;

            // set the read/write timeouts
            serialPort1.ReadTimeout = 1000;
            serialPort1.WriteTimeout = 1000;

            // exchange
            serialPort1.Open();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            ch_com.MouseClick += (s, a) => 
            {cb1.DroppedDown = true;};

            cb1.SelectedIndexChanged += (s, a) =>
            { ch_com.Hide();};
                    
            ch_com2.MouseClick += (s, a) =>
            { cb2.DroppedDown = true; };

            cb2.SelectedIndexChanged += (s, a) =>
            { ch_com2.Hide(); };
            
        }

        // scanning COM-ports
        private void rescan_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cb1.Text = "";                             // clear items
            cb1.Items.Clear();
            if (ports != null)
            {
                cb1.Items.AddRange(ports);  // add COM to textBox
                cb1.SelectedIndex = 0;
            }
        }
        
        // connecting to corresponding COM-port
        private void link_Click(object sender, EventArgs e)
        {            
            if (com_cond == false)
            {
                try
                {
                    serialPort1.PortName = cb1.Text;
                    Data_exchange();                // all settings of COM-port
                    link.FillColor = Color.FromArgb(197, 193, 221);
                    com_cond = true;  
                    cb1.Enabled = false;
                    read.Enabled = true;
                    rescan.Enabled = false;
                    link.HoverState.FillColor = Color.FromArgb(155,151,196);
                }
                catch
                {
                    MessageBox.Show("Error");
                    com_cond = false;                   
                }
            }
            else if (com_cond == true)
            {
                serialPort1.Close();
                link.FillColor = Color.Transparent;
                com_cond = false;
                is_clicked = false;
                read.FillColor = Color.Transparent;
                read.HoverState.FillColor = Color.FromArgb(227, 227, 242);
                cb1.Enabled = true;
                read.Enabled = false;
                rescan.Enabled = true;
                link.HoverState.FillColor = Color.FromArgb(227,227,242);
            }
        }
        
        // construct query
        int w = 0;
        async void query_data()
        {
            await Task.Run(async () =>
            {
                while (is_clicked & com_cond)
                {                       
                        if (w < rowsList.Length)
                        {
                            if (rowsList[w] != null)
                            {
                                try
                                {
                                    int w_node = Convert.ToInt32(rowsList[w].node);
                                    int w_param = Convert.ToInt32(rowsList[w].param);
                                    serialPort1.Write(Mt.query_box(w_node, w_param), 0, 8);
                                       if (rowsList[w].sign_counter < 5)
                                       rowsList[w].sign_counter++;
                                    await Task.Delay(150);
                                }
                                catch {}
                            }
                            w++;
                        }
                        else { w = 0; }                    
                }
            });            
        }

        // sending of query
        bool is_read = false;
        public void read_Click(object sender, EventArgs e)
        {
            if (is_clicked == false)
            {
                is_read = true;
                is_clicked = true;
                link.Enabled = false;
                link2.Enabled = false;
                com_tcp.Hide();
                label_com.Hide();
                label_tcp.Hide();
                btn_add2.Hide();
                    for (int c = 0; c < rowsList.Length; c++)
                {  if (rowsList[c] != null) { rowsList[c].mute = true; } }
                Task.Delay(1000);
                query_data();
                read.FillColor = Color.LightGreen;
                read.HoverState.FillColor = Color.FromArgb(106, 232, 106);
            }
            else
            {
                is_read = false;
                link.Enabled = true;
                link2.Enabled = true;
                if (!l2)  // if link2 not pushed down
                {
                    com_tcp.Show();
                    if (com_tcp.Checked) { label_com.Show(); }
                    else { label_tcp.Show(); }
                }

                is_clicked = false;
                for (int c = 0; c < rowsList.Length; c++)
                { if (rowsList[c] != null) 
                    { 
                        rowsList[c].mute = false;
                        rowsList[c].sign_counter = 5;
                    }
                }
                if (rowsList[7] == null)
                btn_add2.Show();
                read.FillColor = Color.Transparent;
                read.HoverState.FillColor = Color.FromArgb(227, 227, 242);
            }
        }

        // when data received
        public void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] bytes = new byte[9];
            int skolko = serialPort1.Read(bytes, 0, bytes.Length);
            string result1 = Mt.parse_data(bytes, skolko);

            Checker(rowsList[w].node, rowsList[w].param, result1);
        }

        // adding rows
        public Row_else[] rowsList = new Row_else[8];
        int plusY = 103;
        int iAdd = 0;
        bool Ywas_added = false;
        bool Ywas_deleted = false;
        public void Adder_rows()
        {
            if (iAdd <= rowsList.Length)
            {
                if (iAdd<rowsList.Length - 1)
                {btn_add2.Show();}
                else { btn_add2.Hide(); }
                rowsList[iAdd] = new Row_else();
                rowsList[iAdd].Size = new Size(578, 38);
                rowsList[iAdd].Location = new Point(274, 45 + iAdd * 39);
                Controls.Add(rowsList[iAdd]);
                rowsList[iAdd].sign_counter = 5;

                // moving button down
                if (Ywas_deleted)
                {
                    Ywas_deleted = false;
                    plusY += 48;
                }

                Button_loc(plusY);
                iAdd++;
                plusY += 48;
                Ywas_added = true;
            }
        }


        // moving form by header-panel
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
            Point p = PointToScreen(e.Location);
            this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        //array for data to be mb-slave
        public float[] slave_array = new float[8] {0,0,0,0,0,0,0,0};

        // to check does it corresponds to certain node
        private void Checker(string node_rx, string param_rx, string result_rx)
        {
            for (int i = 0; i < rowsList.Length; i++)
            {
                if (rowsList[i]!= null)
                    if ((rowsList[i].node == node_rx) && (rowsList[i].param == param_rx) && (is_read == true))
                    {
                        rowsList[i].sign_counter = 0;
                        rowsList[i].result = result_rx;
                        slave_array[i] = Convert.ToSingle(result_rx);
                    }
            }
        }

        // scanning COM2-ports
        private void rescan2_Click_1(object sender, EventArgs e)
        {
            string[] ports2 = SerialPort.GetPortNames();
            cb2.Text = "";                             // clear items
            cb2.Items.Clear();
            if (ports2 != null)
            {
                cb2.Items.AddRange(ports2);  // add COM to textBox
                cb2.SelectedIndex = 0;
            }
        }

        // connecting to corresponding COM2-port
        bool l2 = false;        // condition of linking
        private void link2_Click_1(object sender, EventArgs e)
        {
            if (com_cond2 == false)
            {
                try
                {
                    serialPort2.PortName = cb2.Text;
                    Data_exchange2();                // all settings of COM2-port
                    link2.FillColor = Color.FromArgb(197, 193, 221);
                    com_cond2 = true;
                    cb2.Enabled = false;
                    rescan2.Enabled = false;
                    link2.HoverState.FillColor = Color.FromArgb(155, 151, 196);
                    com_tcp.Hide();
                    label_tcp.Hide();
                    label_com.Hide();
                    l2 = true;
                }
                catch
                {
                    MessageBox.Show("Error2");
                    com_cond2 = false;
                    l2 = false;
                }
            }
            else if (com_cond2 == true)
            {
                serialPort2.Close();
                link2.FillColor = Color.Transparent;
                com_cond2 = false;
                is_clicked2 = false;
                cb2.Enabled = true;
                rescan2.Enabled = true;
                link2.HoverState.FillColor = Color.FromArgb(227, 227, 242);
                com_tcp.Show();             // prevent mistakes
                    if (com_tcp.Checked) { label_com.Show(); }
                    else { label_tcp.Show();}
                l2 = false;
            }
        }

        // receiving query from server
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] sl_bytes = new byte[8];
            int skolko = serialPort2.Read(sl_bytes, 0, sl_bytes.Length);
            byte[] temp_array = new byte[6];
            for (int g = 0; g < 6; g++)
            { 
                temp_array[g] = sl_bytes[g];
            }
            // check CRC
            Mt2.myCRCrec(temp_array, 6, out byte crcH, out byte crcL);
            if ((crcH == sl_bytes[6]) && (crcL == sl_bytes[7]) && (sl_bytes[0] == 17))
            {
                // check of 03h function modbus
                if (sl_bytes[1] != 3)
                {
                    MessageBox.Show("Supports 03h function of ModBus");
                    return;
                }

                // ckeck of no group query
                bool group_query = false;
                if (sl_bytes[5] != 2)
                   group_query = true;

                // check range of address of parameters (0-7)
                if ((sl_bytes[3] >= 0) && (sl_bytes[3] < 8))
                {
                    if (!group_query)
                    {
                        byte[] complete_slave_answer = new byte[9]; 
                        complete_slave_answer = Mt3.Slaver(slave_array[sl_bytes[3]]);
                        if (complete_slave_answer != null)
                        try
                        {
                            serialPort2.Write(complete_slave_answer, 0, 9);
                        }
                            catch
                            {
                                MessageBox.Show("I can`t to send answer into COM port");
                            }
                    }
                    else
                    {
                        byte amount_regs = sl_bytes[5];
                        byte[] complete_slave_answer = new byte[amount_regs * 2 + 5];
                        complete_slave_answer = Mt3.Slaver1(sl_bytes[3], slave_array, amount_regs);
                        if (complete_slave_answer != null)
                            try
                            {
                                serialPort2.Write(complete_slave_answer, 0, amount_regs * 2 + 5);
                            }
                            catch
                            {
                                MessageBox.Show("I can`t to send answer into COM port");
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Range of addresses of parameters: 0-7");
                    return;
                }                
            }
        }
    }
}        