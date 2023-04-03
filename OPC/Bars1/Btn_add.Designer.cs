namespace Bars1
{
    partial class Btn_add
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
            this.btn_add_ro = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_add_ro
            // 
            this.btn_add_ro.BorderRadius = 7;
            this.btn_add_ro.BorderThickness = 1;
            this.btn_add_ro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_ro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_ro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_ro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_ro.FillColor = System.Drawing.Color.LightGreen;
            this.btn_add_ro.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_ro.ForeColor = System.Drawing.Color.Black;
            this.btn_add_ro.Location = new System.Drawing.Point(0, 0);
            this.btn_add_ro.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_ro.Name = "btn_add_ro";
            this.btn_add_ro.Size = new System.Drawing.Size(160, 51);
            this.btn_add_ro.TabIndex = 0;
            this.btn_add_ro.Text = "+";
            this.btn_add_ro.TextOffset = new System.Drawing.Point(0, -3);
            this.btn_add_ro.Click += new System.EventHandler(this.btn_add_ro_Click);
            // 
            // Btn_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_add_ro);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Btn_add";
            this.Size = new System.Drawing.Size(165, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_add_ro;
    }
}
