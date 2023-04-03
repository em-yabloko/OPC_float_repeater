namespace Bars1
{
    partial class Row_else
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
            this.label1 = new System.Windows.Forms.Label();
            this.iks = new System.Windows.Forms.Label();
            this.tb_param = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_addr = new Guna.UI2.WinForms.Guna2TextBox();
            this.sign_field = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // iks
            // 
            this.iks.AutoSize = true;
            this.iks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iks.Location = new System.Drawing.Point(820, 16);
            this.iks.Name = "iks";
            this.iks.Size = new System.Drawing.Size(30, 29);
            this.iks.TabIndex = 1;
            this.iks.Text = "X";
            // 
            // tb_param
            // 
            this.tb_param.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_param.DefaultText = "Parameter";
            this.tb_param.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_param.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_param.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_param.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_param.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_param.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_param.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_param.Location = new System.Drawing.Point(574, 5);
            this.tb_param.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_param.Name = "tb_param";
            this.tb_param.PasswordChar = '\0';
            this.tb_param.PlaceholderText = "";
            this.tb_param.SelectedText = "";
            this.tb_param.Size = new System.Drawing.Size(124, 44);
            this.tb_param.TabIndex = 5;
            this.tb_param.Enter += new System.EventHandler(this.tb_param_Enter);
            this.tb_param.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_param_MouseClick);
            // 
            // tb_addr
            // 
            this.tb_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_addr.DefaultText = "Device";
            this.tb_addr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_addr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_addr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_addr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_addr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_addr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_addr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_addr.Location = new System.Drawing.Point(446, 5);
            this.tb_addr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.PasswordChar = '\0';
            this.tb_addr.PlaceholderText = "";
            this.tb_addr.SelectedText = "";
            this.tb_addr.Size = new System.Drawing.Size(102, 45);
            this.tb_addr.TabIndex = 3;
            this.tb_addr.Enter += new System.EventHandler(this.tb_addr_Enter);
            this.tb_addr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_addr_MouseClick_1);
            // 
            // sign_field
            // 
            this.sign_field.BorderThickness = 1;
            this.sign_field.FillColor = System.Drawing.Color.Silver;
            this.sign_field.Location = new System.Drawing.Point(733, 10);
            this.sign_field.Name = "sign_field";
            this.sign_field.PolygonSkip = 1;
            this.sign_field.Rotate = 0F;
            this.sign_field.RoundedRadius = 10;
            this.sign_field.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.sign_field.Size = new System.Drawing.Size(48, 39);
            this.sign_field.TabIndex = 6;
            this.sign_field.Text = "guna2Shapes1";
            this.sign_field.Zoom = 80;
            // 
            // Row_else
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sign_field);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.iks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_param);
            this.Name = "Row_else";
            this.Size = new System.Drawing.Size(855, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iks;
        private Guna.UI2.WinForms.Guna2TextBox tb_param;
        private Guna.UI2.WinForms.Guna2TextBox tb_addr;
        private Guna.UI2.WinForms.Guna2Shapes sign_field;
    }
}
