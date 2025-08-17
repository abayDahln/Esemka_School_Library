namespace Esemka_School_Library
{
    partial class Day_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnDay
            // 
            this.btnDay.BorderRadius = 8;
            this.btnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(250)))), ((int)(((byte)(86)))));
            this.btnDay.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.ForeColor = System.Drawing.Color.White;
            this.btnDay.Location = new System.Drawing.Point(9, 7);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(177, 46);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "3 Day";
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // Day_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDay);
            this.Name = "Day_Control";
            this.Size = new System.Drawing.Size(195, 60);
            this.Load += new System.EventHandler(this.Day_Control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnDay;
    }
}
