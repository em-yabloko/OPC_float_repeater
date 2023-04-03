namespace Bars1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mini = new System.Windows.Forms.Label();
            this.iks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_tcp = new System.Windows.Forms.Label();
            this.label_com = new System.Windows.Forms.Label();
            this.com_tcp = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link2 = new Guna.UI2.WinForms.Guna2Button();
            this.rescan2 = new Guna.UI2.WinForms.Guna2Button();
            this.ch_com2 = new System.Windows.Forms.Label();
            this.cb2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.read = new Guna.UI2.WinForms.Guna2Button();
            this.link = new Guna.UI2.WinForms.Guna2Button();
            this.rescan = new Guna.UI2.WinForms.Guna2Button();
            this.ch_com = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.btn_add2 = new Bars1.Btn_add();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.mini);
            this.panel1.Controls.Add(this.iks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // mini
            // 
            this.mini.AutoSize = true;
            this.mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mini.ForeColor = System.Drawing.Color.Indigo;
            this.mini.Location = new System.Drawing.Point(785, 6);
            this.mini.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(25, 36);
            this.mini.TabIndex = 5;
            this.mini.Text = "-";
            // 
            // iks
            // 
            this.iks.AutoSize = true;
            this.iks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iks.ForeColor = System.Drawing.Color.Indigo;
            this.iks.Location = new System.Drawing.Point(814, 15);
            this.iks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iks.Name = "iks";
            this.iks.Size = new System.Drawing.Size(27, 26);
            this.iks.TabIndex = 4;
            this.iks.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label_tcp);
            this.panel2.Controls.Add(this.label_com);
            this.panel2.Controls.Add(this.com_tcp);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.link2);
            this.panel2.Controls.Add(this.rescan2);
            this.panel2.Controls.Add(this.ch_com2);
            this.panel2.Controls.Add(this.cb2);
            this.panel2.Controls.Add(this.read);
            this.panel2.Controls.Add(this.link);
            this.panel2.Controls.Add(this.rescan);
            this.panel2.Controls.Add(this.ch_com);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 394);
            this.panel2.TabIndex = 1;
            // 
            // label_tcp
            // 
            this.label_tcp.AutoSize = true;
            this.label_tcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.label_tcp.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.label_tcp.ForeColor = System.Drawing.Color.White;
            this.label_tcp.Location = new System.Drawing.Point(183, 191);
            this.label_tcp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tcp.Name = "label_tcp";
            this.label_tcp.Size = new System.Drawing.Size(54, 29);
            this.label_tcp.TabIndex = 13;
            this.label_tcp.Text = "TCP";
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.BackColor = System.Drawing.Color.White;
            this.label_com.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.label_com.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_com.Location = new System.Drawing.Point(153, 191);
            this.label_com.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(60, 29);
            this.label_com.TabIndex = 12;
            this.label_com.Text = "COM";
            // 
            // com_tcp
            // 
            this.com_tcp.Checked = true;
            this.com_tcp.CheckedState.BorderColor = System.Drawing.Color.White;
            this.com_tcp.CheckedState.FillColor = System.Drawing.Color.White;
            this.com_tcp.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.com_tcp.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.com_tcp.Location = new System.Drawing.Point(136, 185);
            this.com_tcp.Margin = new System.Windows.Forms.Padding(2);
            this.com_tcp.Name = "com_tcp";
            this.com_tcp.Size = new System.Drawing.Size(121, 39);
            this.com_tcp.TabIndex = 3;
            this.com_tcp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.com_tcp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.com_tcp.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.com_tcp.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.label3.Location = new System.Drawing.Point(15, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "to server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "to devices";
            // 
            // link2
            // 
            this.link2.BackColor = System.Drawing.Color.Transparent;
            this.link2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.link2.BorderThickness = 1;
            this.link2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.link2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.link2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.link2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.link2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.link2.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.link2.ForeColor = System.Drawing.Color.Black;
            this.link2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.link2.Location = new System.Drawing.Point(136, 228);
            this.link2.Margin = new System.Windows.Forms.Padding(2);
            this.link2.Name = "link2";
            this.link2.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.link2.Size = new System.Drawing.Size(121, 41);
            this.link2.TabIndex = 5;
            this.link2.Text = "Link";
            this.link2.Click += new System.EventHandler(this.link2_Click_1);
            // 
            // rescan2
            // 
            this.rescan2.BackColor = System.Drawing.SystemColors.Highlight;
            this.rescan2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rescan2.BorderThickness = 1;
            this.rescan2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rescan2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rescan2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rescan2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rescan2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.rescan2.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.rescan2.ForeColor = System.Drawing.Color.Black;
            this.rescan2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.rescan2.Location = new System.Drawing.Point(15, 228);
            this.rescan2.Margin = new System.Windows.Forms.Padding(2);
            this.rescan2.Name = "rescan2";
            this.rescan2.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.rescan2.Size = new System.Drawing.Size(117, 41);
            this.rescan2.TabIndex = 6;
            this.rescan2.Text = "Scan";
            this.rescan2.Click += new System.EventHandler(this.rescan2_Click_1);
            // 
            // ch_com2
            // 
            this.ch_com2.AllowDrop = true;
            this.ch_com2.BackColor = System.Drawing.Color.White;
            this.ch_com2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch_com2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ch_com2.Location = new System.Drawing.Point(15, 273);
            this.ch_com2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ch_com2.Name = "ch_com2";
            this.ch_com2.Size = new System.Drawing.Size(243, 39);
            this.ch_com2.TabIndex = 8;
            this.ch_com2.Text = "Choose COM...";
            this.ch_com2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb2
            // 
            //this.cb2.AllowDrop = true;
            this.cb2.BackColor = System.Drawing.Color.Transparent;
            this.cb2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FocusedColor = System.Drawing.Color.Transparent;
            this.cb2.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cb2.FocusedState.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.cb2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.cb2.ForeColor = System.Drawing.Color.Black;
            this.cb2.FormattingEnabled = true;
            this.cb2.HoverState.FillColor = System.Drawing.Color.White;
            this.cb2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.cb2.IntegralHeight = false;
            this.cb2.ItemHeight = 36;
            this.cb2.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cb2.ItemsAppearance.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.cb2.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cb2.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(236)))));
            this.cb2.Location = new System.Drawing.Point(15, 273);
            this.cb2.Margin = new System.Windows.Forms.Padding(2);
            this.cb2.Name = "cb2";
            this.cb2.ShadowDecoration.Color = System.Drawing.Color.Indigo;
            this.cb2.Size = new System.Drawing.Size(244, 42);
            this.cb2.Sorted = true;
            this.cb2.TabIndex = 7;
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.Transparent;
            this.read.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.read.BorderThickness = 1;
            this.read.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.read.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.read.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.read.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.read.Enabled = false;
            this.read.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.read.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.read.ForeColor = System.Drawing.Color.Black;
            this.read.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.read.Location = new System.Drawing.Point(15, 333);
            this.read.Margin = new System.Windows.Forms.Padding(2);
            this.read.Name = "read";
            this.read.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.read.Size = new System.Drawing.Size(243, 48);
            this.read.TabIndex = 4;
            this.read.Text = "Read";
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.link.BorderThickness = 1;
            this.link.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.link.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.link.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.link.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.link.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.link.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.link.ForeColor = System.Drawing.Color.Black;
            this.link.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.link.Location = new System.Drawing.Point(136, 82);
            this.link.Margin = new System.Windows.Forms.Padding(2);
            this.link.Name = "link";
            this.link.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.link.Size = new System.Drawing.Size(121, 41);
            this.link.TabIndex = 2;
            this.link.Text = "Link";
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // rescan
            // 
            this.rescan.BackColor = System.Drawing.SystemColors.Highlight;
            this.rescan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rescan.BorderThickness = 1;
            this.rescan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rescan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rescan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rescan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rescan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.rescan.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.rescan.ForeColor = System.Drawing.Color.Black;
            this.rescan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.rescan.Location = new System.Drawing.Point(15, 82);
            this.rescan.Margin = new System.Windows.Forms.Padding(2);
            this.rescan.Name = "rescan";
            this.rescan.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.rescan.Size = new System.Drawing.Size(117, 41);
            this.rescan.TabIndex = 2;
            this.rescan.Text = "Scan";
            this.rescan.Click += new System.EventHandler(this.rescan_Click);
            // 
            // ch_com
            // 
            this.ch_com.AllowDrop = true;
            this.ch_com.BackColor = System.Drawing.Color.White;
            this.ch_com.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch_com.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ch_com.Location = new System.Drawing.Point(15, 127);
            this.ch_com.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ch_com.Name = "ch_com";
            this.ch_com.Size = new System.Drawing.Size(243, 39);
            this.ch_com.TabIndex = 3;
            this.ch_com.Text = "Choose COM...";
            this.ch_com.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Settings";
            // 
            // cb1
            // 
            //this.cb1.AllowDrop = true;
            this.cb1.BackColor = System.Drawing.Color.Transparent;
            this.cb1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FocusedColor = System.Drawing.Color.Transparent;
            this.cb1.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cb1.FocusedState.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb1.ForeColor = System.Drawing.Color.Black;
            this.cb1.FormattingEnabled = true;
            this.cb1.HoverState.FillColor = System.Drawing.Color.White;
            this.cb1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.cb1.IntegralHeight = false;
            this.cb1.ItemHeight = 36;
            this.cb1.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cb1.ItemsAppearance.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.cb1.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cb1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(236)))));
            this.cb1.Location = new System.Drawing.Point(15, 127);
            this.cb1.Margin = new System.Windows.Forms.Padding(2);
            this.cb1.Name = "cb1";
            this.cb1.ShadowDecoration.Color = System.Drawing.Color.Indigo;
            this.cb1.Size = new System.Drawing.Size(244, 42);
            this.cb1.Sorted = true;
            this.cb1.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // btn_add2
            // 
            this.btn_add2.BackColor = System.Drawing.Color.Transparent;
            this.btn_add2.Location = new System.Drawing.Point(513, 55);
            this.btn_add2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(109, 45);
            this.btn_add2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(853, 447);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button rescan;
        private System.Windows.Forms.Label ch_com;
        private Guna.UI2.WinForms.Guna2ComboBox cb1;
        private System.IO.Ports.SerialPort serialPort1;
        private Guna.UI2.WinForms.Guna2Button link;
        private Guna.UI2.WinForms.Guna2Button read;
        private Btn_add btn_add2;
        private System.Windows.Forms.Label iks;
        private System.Windows.Forms.Label mini;
        private Guna.UI2.WinForms.Guna2Button link2;
        private Guna.UI2.WinForms.Guna2Button rescan2;
        private System.Windows.Forms.Label ch_com2;
        private Guna.UI2.WinForms.Guna2ComboBox cb2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch com_tcp;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.Label label_tcp;
    }
}