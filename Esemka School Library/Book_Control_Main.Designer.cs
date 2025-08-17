namespace Esemka_School_Library
{
    partial class Book_Control_Main
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblname = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnlike = new Guna.UI2.WinForms.Guna2CircleButton();
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 14;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // lblname
            // 
            this.lblname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblname.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(10, 307);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblname.Size = new System.Drawing.Size(209, 112);
            this.lblname.TabIndex = 36;
            this.lblname.Text = "The Innovators: How a Group of Hackers, Geniuses, and Geeks Created the Digital R" +
    "evolution";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcategory.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblcategory.Location = new System.Drawing.Point(11, 425);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblcategory.Size = new System.Drawing.Size(94, 26);
            this.lblcategory.TabIndex = 39;
            this.lblcategory.Text = "Adventure";
            this.lblcategory.Click += new System.EventHandler(this.lblcategory_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(87, 27);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(57, 63);
            this.id.TabIndex = 42;
            this.id.Text = "1";
            this.id.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(232, 465);
            this.guna2Panel1.TabIndex = 43;
            this.guna2Panel1.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // btnlike
            // 
            this.btnlike.Animated = true;
            this.btnlike.AnimatedGIF = true;
            this.btnlike.BorderColor = System.Drawing.Color.Silver;
            this.btnlike.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnlike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlike.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlike.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlike.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlike.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlike.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnlike.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlike.ForeColor = System.Drawing.Color.White;
            this.btnlike.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnlike.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnlike.Image = global::Esemka_School_Library.Properties.Resources.favorite;
            this.btnlike.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnlike.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlike.Location = new System.Drawing.Point(174, 410);
            this.btnlike.Name = "btnlike";
            this.btnlike.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnlike.Size = new System.Drawing.Size(45, 45);
            this.btnlike.TabIndex = 41;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // picImage
            // 
            this.picImage.BorderRadius = 6;
            this.picImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(25, 23);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(184, 278);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 37;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // Book_Control_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnlike);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Book_Control_Main";
            this.Size = new System.Drawing.Size(232, 465);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CircleButton btnlike;
        public Guna.UI2.WinForms.Guna2PictureBox picImage;
        public System.Windows.Forms.Label lblcategory;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
