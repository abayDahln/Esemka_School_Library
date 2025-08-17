namespace Esemka_School_Library
{
    partial class Return_Confirm_Dialog
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnYes = new Guna.UI2.WinForms.Guna2Button();
            this.lblname = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.btnNo);
            this.guna2Panel1.Controls.Add(this.btnYes);
            this.guna2Panel1.Controls.Add(this.lblname);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(532, 244);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnNo
            // 
            this.btnNo.Animated = true;
            this.btnNo.AnimatedGIF = true;
            this.btnNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.btnNo.BorderRadius = 8;
            this.btnNo.BorderThickness = 2;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.btnNo.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.btnNo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.btnNo.Location = new System.Drawing.Point(277, 141);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(161, 51);
            this.btnNo.TabIndex = 47;
            this.btnNo.Text = "No";
            this.btnNo.TextOffset = new System.Drawing.Point(0, 2);
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Animated = true;
            this.btnYes.AnimatedGIF = true;
            this.btnYes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.btnYes.BorderRadius = 8;
            this.btnYes.BorderThickness = 2;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnYes.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnYes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnYes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnYes.Location = new System.Drawing.Point(81, 141);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(161, 51);
            this.btnYes.TabIndex = 46;
            this.btnYes.Text = "Yes";
            this.btnYes.TextOffset = new System.Drawing.Point(0, 2);
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(70, 50);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblname.Size = new System.Drawing.Size(394, 50);
            this.lblname.TabIndex = 45;
            this.lblname.Text = "Has this book been returned?";
            // 
            // Return_Confirm_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 244);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return_Confirm_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Confirm_Dialog";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label lblname;
        public Guna.UI2.WinForms.Guna2Button btnNo;
        public Guna.UI2.WinForms.Guna2Button btnYes;
    }
}