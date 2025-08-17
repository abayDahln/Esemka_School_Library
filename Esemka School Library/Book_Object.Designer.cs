namespace Esemka_School_Library
{
    partial class Book_Object
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
            this.categoriesName = new System.Windows.Forms.Label();
            this.categoriesImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonC = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesImage)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesName
            // 
            this.categoriesName.BackColor = System.Drawing.Color.Transparent;
            this.categoriesName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoriesName.Font = new System.Drawing.Font("Poppins", 12F);
            this.categoriesName.Location = new System.Drawing.Point(0, 153);
            this.categoriesName.Name = "categoriesName";
            this.categoriesName.Size = new System.Drawing.Size(162, 37);
            this.categoriesName.TabIndex = 1;
            this.categoriesName.Text = "Science_Fiction";
            this.categoriesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoriesName.Click += new System.EventHandler(this.label1_Click_1);
            this.categoriesName.MouseHover += new System.EventHandler(this.categoriesName_MouseHover);
            // 
            // categoriesImage
            // 
            this.categoriesImage.BackColor = System.Drawing.Color.Transparent;
            this.categoriesImage.BorderRadius = 14;
            this.categoriesImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesImage.Image = global::Esemka_School_Library.Properties.Resources.Atomic_Habits;
            this.categoriesImage.ImageRotate = 0F;
            this.categoriesImage.Location = new System.Drawing.Point(0, 0);
            this.categoriesImage.Margin = new System.Windows.Forms.Padding(5);
            this.categoriesImage.Name = "categoriesImage";
            this.categoriesImage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesImage.Size = new System.Drawing.Size(162, 153);
            this.categoriesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoriesImage.TabIndex = 1;
            this.categoriesImage.TabStop = false;
            this.categoriesImage.UseTransparentBackground = true;
            this.categoriesImage.MouseHover += new System.EventHandler(this.categoriesImage_MouseHover_1);
            // 
            // buttonC
            // 
            this.buttonC.Animated = true;
            this.buttonC.AnimatedGIF = true;
            this.buttonC.BackColor = System.Drawing.Color.Transparent;
            this.buttonC.BorderRadius = 12;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(3, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(156, 184);
            this.buttonC.TabIndex = 0;
            this.buttonC.UseTransparentBackground = true;
            this.buttonC.Visible = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            this.buttonC.MouseLeave += new System.EventHandler(this.buttonC_MouseLeave);
            this.buttonC.MouseHover += new System.EventHandler(this.buttonC_MouseHover);
            // 
            // Book_Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.categoriesImage);
            this.Controls.Add(this.categoriesName);
            this.Name = "Book_Object";
            this.Size = new System.Drawing.Size(162, 190);
            this.Load += new System.EventHandler(this.Book_Object_Load);
            this.MouseHover += new System.EventHandler(this.Book_Object_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label categoriesName;
        public Guna.UI2.WinForms.Guna2PictureBox categoriesImage;
        private Guna.UI2.WinForms.Guna2Button buttonC;
    }
}
