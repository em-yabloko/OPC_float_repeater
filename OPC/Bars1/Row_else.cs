using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Bars1
{
    public partial class Row_else : UserControl
    {
        public static Delegate Del_delete;
        public Row_else()
        {
            InitializeComponent();
            label1.Text = "No data";

            iks.MouseEnter += (s, a) =>
            { iks.ForeColor = Color.Red; };

            iks.MouseLeave += (s, a) =>
            { iks.ForeColor = Color.Black; };

            iks.MouseClick += (s, a) =>
            {
                this.Dispose();
                if (this.IsDisposed)
                {
                    Del_delete.DynamicInvoke();
                }
            };

            tb_addr.Leave += (s, a) =>
            { node = tb_addr.Text; };

            tb_param.Leave += (s, a) =>
            { param = tb_param.Text; };

            tb_addr.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    this.ActiveControl = label1;
            };

            tb_param.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                    this.ActiveControl = label1;
            };            
        }

        // choosing of device address

        private string _result;
        public string result
        {
            get { return _result; }
            set 
            {
                _result = value;
                Invoke((Action)(() =>
                {
                    label1.Text = result;
                }));                
            }
        }
        private byte device_addr()
        {
            return Convert.ToByte(tb_addr);
        }

        // choosing of param address
        private byte param_addr()
        {
            return Convert.ToByte(tb_param);
        }

        private void tb_param_MouseClick(object sender, MouseEventArgs e)
        {
            tb_param.Clear();
            tb_param.ForeColor = Color.Black;
            tb_param.Font = new Font("Segoe UI", 16F);
        }

        // node address
        private string _node;
        public string node
        {
            get { return _node; }
            set
            {
                _node = value;
            }
        }

        // param address
        private string _param;
        public string param
        {
            get { return _param; }
            set
            {
                _param = value;
            }
        }

        // prologue for mute function
        private bool _mute;
        public bool mute
        {
            get { return _mute; }
            set
            {
                _mute = value;
                if (_mute == true)
                    { 
                        iks.Hide();
                    if (tb_addr.Text != "Device")
                    {
                        tb_addr.DisabledState.FillColor = Color.White;
                        tb_addr.DisabledState.ForeColor = Color.Black;
                    }
                    else
                    {
                        tb_addr.DisabledState.FillColor = Color.White;
                        tb_addr.DisabledState.ForeColor = Color.Silver;
                    }
                    if (tb_param.Text != "Parameter")
                    {
                        tb_param.DisabledState.FillColor = Color.White;
                        tb_param.DisabledState.ForeColor = Color.Black;
                    }
                    else
                    {
                        tb_param.DisabledState.FillColor = Color.White;
                        tb_param.DisabledState.ForeColor = Color.Silver;
                    }
                    tb_addr.Enabled = false;
                    tb_param.Enabled = false;
                }
                else
                    {
                        iks.Show();
                        tb_addr.Enabled = true;
                        tb_param.Enabled = true;                    
                }
            }
        }

        private void tb_addr_MouseClick_1(object sender, MouseEventArgs e)
        {
            tb_addr.Clear();
            tb_addr.ForeColor = Color.Black;
            tb_addr.Font = new Font("Segoe UI", 16F);
        }

        private void tb_addr_Enter(object sender, EventArgs e)
        {
            tb_addr.Clear();
            tb_addr.ForeColor = Color.Black;
            tb_addr.Font = new Font("Segoe UI", 16F);
        }

        private void tb_param_Enter(object sender, EventArgs e)
        {
            tb_param.Clear();
            tb_param.ForeColor = Color.Black;
            tb_param.Font = new Font("Segoe UI", 16F);
        }

        // counter of field disconnection
        private byte _sign_counter;
        public byte sign_counter
        {
            get { return _sign_counter; }
            set
            {
                _sign_counter = value;
                if (_sign_counter < 5)
                {
                    this.sign_field.FillColor = Color.LightGreen;
                }
                else
                {
                    this.sign_field.FillColor = Color.Silver;
                }
            }
        }
    }
}
