using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bars1
{
    public partial class Switch_tcp : UserControl
    {
        public string new_ip = "10.224.226.1";
        public string new_port = "502";
        mb_tcp mtt = new mb_tcp();

        public Switch_tcp()
        {
            InitializeComponent();

            tb_ip.Leave += (s, a) =>
            {
                if (!lnk)
                new_ip = tb_ip.Text;
                mtt.ips = new_ip;
            };

            tb_port.Leave += (s, a) =>
            {
                if (!lnk)
                new_port = tb_port.Text;
            };

            tb_ip.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    this.ActiveControl = link_tcp;
            };

            tb_port.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    this.ActiveControl = link_tcp;
            };
        }


        mb_tcp mb_Tcp = new mb_tcp();
        Message_types Mt5 = new Message_types();
        bool lnk = false;
        bool once_linled = false;
        private async void link_tcp_Click(object sender, EventArgs e)
        {
            lnk = true;
            once_linled = true;
            link_tcp.Enabled = false;
            tb_ip.Enabled = false;
            tb_port.Enabled = false;
                await Task.Run(() =>
                    {
                        Form2 f2 = new Form2();
                        if (!f2.ad)
                            f2.ad = true;

                        try
                        {
                            bool smak = false;
                            do
                            {
                                mb_Tcp.Rx(false, false, new_ip, new_port);          // false for temp only

                                byte transition_id0 = mb_Tcp.bag[0];
                                byte transition_id1 = mb_Tcp.bag[1];
                                byte start_addr_tcp = mb_Tcp.bag[9];    // address of start the inner register
                                byte amount_regs_tcp = mb_Tcp.bag[11];  // amount of registers the inner registers
                                byte[] complete_tcp = Mt5.Slaver_tcp(transition_id0, transition_id1, start_addr_tcp, f2.slave_array, amount_regs_tcp);
                                smak = true;
                            }
                            while (!smak);
                        }
                        catch
                        {
                            MessageBox.Show("No connection!");
                            lnk = false;

                            Invoke((Action)(() =>
                            {
                                link_tcp.Enabled = true;
                                tb_ip.Enabled = true;
                                tb_port.Enabled = true;
                            }));
                        }
                    });           
        }

        private void tb_ip_MouseClick(object sender, MouseEventArgs e)
        {
            tb_ip.Clear();
            tb_ip.ForeColor = Color.Black;
            tb_ip.Font = new Font("Segoe UI", 16F);
        }

        private void tb_ip_Enter(object sender, EventArgs e)
        {
            tb_ip.Clear();
            tb_ip.ForeColor = Color.Black;
            tb_ip.Font = new Font("Segoe UI", 16F);
        }

        private void tb_port_MouseClick(object sender, MouseEventArgs e)
        {
            tb_port.Clear();
            tb_port.ForeColor = Color.Black;
            tb_port.Font = new Font("Segoe UI", 16F);
        }

        private void tb_port_Enter(object sender, EventArgs e)
        {
            tb_port.Clear();
            tb_port.ForeColor = Color.Black;
            tb_port.Font = new Font("Segoe UI", 16F);
        }
    }
}
