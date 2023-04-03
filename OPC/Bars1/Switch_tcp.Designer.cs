namespace Bars1
{
    partial class Switch_tcp
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.link_tcp = new Guna.UI2.WinForms.Guna2Button();
            this.tb_ip = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_port = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // link_tcp
            // 
            this.link_tcp.BackColor = System.Drawing.Color.Transparent;
            this.link_tcp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.link_tcp.BorderThickness = 1;
            this.link_tcp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.link_tcp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.link_tcp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.link_tcp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.link_tcp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.link_tcp.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.link_tcp.ForeColor = System.Drawing.Color.Black;
            this.link_tcp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.link_tcp.Location = new System.Drawing.Point(132, 36);
            this.link_tcp.Margin = new System.Windows.Forms.Padding(2);
            this.link_tcp.Name = "link_tcp";
            this.link_tcp.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.link_tcp.Size = new System.Drawing.Size(109, 32);
            this.link_tcp.TabIndex = 9;
            this.link_tcp.Text = "Link";
            this.link_tcp.Click += new System.EventHandler(this.link_tcp_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ip.DefaultText = " Type IP of this server...";
            this.tb_ip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ip.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tb_ip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ip.Location = new System.Drawing.Point(4, 2);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.PasswordChar = '\0';
            this.tb_ip.PlaceholderText = "";
            this.tb_ip.SelectedText = "";
            this.tb_ip.Size = new System.Drawing.Size(237, 32);
            this.tb_ip.TabIndex = 13;
            this.tb_ip.Enter += new System.EventHandler(this.tb_ip_Enter);
            this.tb_ip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_ip_MouseClick);
            // 
            // tb_port
            // 
            this.tb_port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_port.DefaultText = " Port: 502";
            this.tb_port.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_port.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_port.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_port.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_port.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_port.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tb_port.ForeColor = System.Drawing.Color.Black;
            this.tb_port.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_port.Location = new System.Drawing.Point(4, 36);
            this.tb_port.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_port.Name = "tb_port";
            this.tb_port.PasswordChar = '\0';
            this.tb_port.PlaceholderText = "";
            this.tb_port.SelectedText = "";
            this.tb_port.Size = new System.Drawing.Size(121, 32);
            this.tb_port.TabIndex = 14;
            this.tb_port.Enter += new System.EventHandler(this.tb_port_Enter);
            this.tb_port.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_port_MouseClick);
            // 
            // Switch_tcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.link_tcp);
            this.Name = "Switch_tcp";
            this.Size = new System.Drawing.Size(246, 71);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button link_tcp;
        private Guna.UI2.WinForms.Guna2TextBox tb_ip;
        private Guna.UI2.WinForms.Guna2TextBox tb_port;
    }
}
