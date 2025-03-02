namespace Esemka_School_Library
{
    partial class Book_Control
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.id = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbllike = new System.Windows.Forms.Label();
            this.btnlike = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblrating = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.picImage);
            this.guna2Panel1.Controls.Add(this.id);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(514, 301);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // picImage
            // 
            this.picImage.BorderRadius = 6;
            this.picImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(15, 13);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(181, 277);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(7, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(57, 63);
            this.id.TabIndex = 43;
            this.id.Text = "1";
            this.id.Visible = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnSave);
            this.guna2Panel3.Controls.Add(this.lbllike);
            this.guna2Panel3.Controls.Add(this.btnlike);
            this.guna2Panel3.Controls.Add(this.lblrating);
            this.guna2Panel3.Controls.Add(this.lblname);
            this.guna2Panel3.Controls.Add(this.lblcategory);
            this.guna2Panel3.Controls.Add(this.rating);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(194, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(320, 301);
            this.guna2Panel3.TabIndex = 39;
            this.guna2Panel3.Click += new System.EventHandler(this.guna2Panel3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AnimatedGIF = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnSave.Image = global::Esemka_School_Library.Properties.Resources.bookmark;
            this.btnSave.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(258, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 42;
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbllike
            // 
            this.lbllike.AutoSize = true;
            this.lbllike.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllike.ForeColor = System.Drawing.Color.Black;
            this.lbllike.Location = new System.Drawing.Point(68, 246);
            this.lbllike.Name = "lbllike";
            this.lbllike.Size = new System.Drawing.Size(92, 34);
            this.lbllike.TabIndex = 41;
            this.lbllike.Text = "100 likes";
            // 
            // btnlike
            // 
            this.btnlike.Animated = true;
            this.btnlike.AnimatedGIF = true;
            this.btnlike.BorderColor = System.Drawing.Color.Silver;
            this.btnlike.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.btnlike.CheckedState.Image = global::Esemka_School_Library.Properties.Resources.favorite_fill;
            this.btnlike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlike.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlike.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlike.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlike.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlike.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnlike.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlike.ForeColor = System.Drawing.Color.White;
            this.btnlike.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnlike.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnlike.Image = global::Esemka_School_Library.Properties.Resources.favorite;
            this.btnlike.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnlike.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlike.Location = new System.Drawing.Point(19, 236);
            this.btnlike.Name = "btnlike";
            this.btnlike.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnlike.Size = new System.Drawing.Size(45, 45);
            this.btnlike.TabIndex = 40;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // lblrating
            // 
            this.lblrating.AutoSize = true;
            this.lblrating.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrating.ForeColor = System.Drawing.Color.DimGray;
            this.lblrating.Location = new System.Drawing.Point(141, 201);
            this.lblrating.Name = "lblrating";
            this.lblrating.Size = new System.Drawing.Size(44, 28);
            this.lblrating.TabIndex = 37;
            this.lblrating.Text = "( 5 )";
            // 
            // lblname
            // 
            this.lblname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblname.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(2, 16);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblname.Size = new System.Drawing.Size(313, 146);
            this.lblname.TabIndex = 35;
            this.lblname.Text = "The Innovators: How a Group of Hackers, Geniuses, and Geeks Created the Digital R" +
    "evolution";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblcategory.Location = new System.Drawing.Point(10, 162);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblcategory.Size = new System.Drawing.Size(100, 28);
            this.lblcategory.TabIndex = 38;
            this.lblcategory.Text = "Adventure";
            this.lblcategory.Click += new System.EventHandler(this.lblcategory_Click);
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.BorderColor = System.Drawing.Color.DarkGray;
            this.rating.Location = new System.Drawing.Point(17, 198);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Gold;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(120, 28);
            this.rating.TabIndex = 2;
            this.rating.Value = 5F;
            this.rating.Click += new System.EventHandler(this.rating_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 14;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Book_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Book_Control";
            this.Size = new System.Drawing.Size(514, 301);
            this.Load += new System.EventHandler(this.Book_Control_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CircleButton btnlike;
        private Guna.UI2.WinForms.Guna2CircleButton btnSave;
        public Guna.UI2.WinForms.Guna2PictureBox picImage;
        public Guna.UI2.WinForms.Guna2RatingStar rating;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label lblrating;
        public System.Windows.Forms.Label lblcategory;
        public System.Windows.Forms.Label lbllike;
        public System.Windows.Forms.Label id;
    }
}
