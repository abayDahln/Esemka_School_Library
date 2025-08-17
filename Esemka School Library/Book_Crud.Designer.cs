namespace Esemka_School_Library
{
    partial class Book_Crud
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
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblstock = new System.Windows.Forms.Label();
            this.upd = new Guna.UI2.WinForms.Guna2Button();
            this.del = new Guna.UI2.WinForms.Guna2Button();
            this.lbllike = new System.Windows.Forms.Label();
            this.lblrating = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnlike = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // picImage
            // 
            this.picImage.BorderRadius = 12;
            this.picImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(27, 27);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(205, 307);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 40;
            this.picImage.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.lblstock);
            this.guna2Panel3.Controls.Add(this.upd);
            this.guna2Panel3.Controls.Add(this.del);
            this.guna2Panel3.Controls.Add(this.lbllike);
            this.guna2Panel3.Controls.Add(this.btnlike);
            this.guna2Panel3.Controls.Add(this.lblrating);
            this.guna2Panel3.Controls.Add(this.lblname);
            this.guna2Panel3.Controls.Add(this.lblcategory);
            this.guna2Panel3.Controls.Add(this.rating);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(235, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(276, 364);
            this.guna2Panel3.TabIndex = 41;
            this.guna2Panel3.UseTransparentBackground = true;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.ForeColor = System.Drawing.Color.Black;
            this.lblstock.Location = new System.Drawing.Point(171, 248);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(82, 28);
            this.lblstock.TabIndex = 54;
            this.lblstock.Text = "Stock: 99";
            // 
            // upd
            // 
            this.upd.Animated = true;
            this.upd.BackColor = System.Drawing.Color.Transparent;
            this.upd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(224)))));
            this.upd.BorderRadius = 6;
            this.upd.BorderThickness = 2;
            this.upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.upd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.upd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.upd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.upd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(64)))), ((int)(((byte)(144)))));
            this.upd.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd.ForeColor = System.Drawing.Color.White;
            this.upd.HoverState.FillColor = System.Drawing.Color.White;
            this.upd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(64)))), ((int)(((byte)(144)))));
            this.upd.IndicateFocus = true;
            this.upd.Location = new System.Drawing.Point(28, 297);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(103, 44);
            this.upd.TabIndex = 53;
            this.upd.Text = "Update";
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // del
            // 
            this.del.Animated = true;
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(224)))));
            this.del.BorderRadius = 6;
            this.del.BorderThickness = 2;
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.del.FillColor = System.Drawing.Color.Red;
            this.del.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.ForeColor = System.Drawing.Color.White;
            this.del.HoverState.FillColor = System.Drawing.Color.White;
            this.del.HoverState.ForeColor = System.Drawing.Color.Red;
            this.del.IndicateFocus = true;
            this.del.Location = new System.Drawing.Point(156, 297);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(103, 44);
            this.del.TabIndex = 52;
            this.del.Text = "Delete";
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // lbllike
            // 
            this.lbllike.AutoSize = true;
            this.lbllike.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllike.ForeColor = System.Drawing.Color.Black;
            this.lbllike.Location = new System.Drawing.Point(63, 246);
            this.lbllike.Name = "lbllike";
            this.lbllike.Size = new System.Drawing.Size(75, 28);
            this.lbllike.TabIndex = 41;
            this.lbllike.Text = "100 likes";
            // 
            // lblrating
            // 
            this.lblrating.AutoSize = true;
            this.lblrating.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrating.ForeColor = System.Drawing.Color.DimGray;
            this.lblrating.Location = new System.Drawing.Point(140, 196);
            this.lblrating.Name = "lblrating";
            this.lblrating.Size = new System.Drawing.Size(44, 28);
            this.lblrating.TabIndex = 37;
            this.lblrating.Text = "( 5 )";
            // 
            // lblname
            // 
            this.lblname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblname.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(10, 16);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblname.Size = new System.Drawing.Size(263, 146);
            this.lblname.TabIndex = 35;
            this.lblname.Text = "The Innovators: How a Group of Hackers, Geniuses, and Geeks Created the Digital R" +
    "evolution";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblcategory.Location = new System.Drawing.Point(13, 159);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblcategory.Size = new System.Drawing.Size(100, 28);
            this.lblcategory.TabIndex = 38;
            this.lblcategory.Text = "Adventure";
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.BorderColor = System.Drawing.Color.DarkGray;
            this.rating.Location = new System.Drawing.Point(18, 193);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Gold;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(120, 28);
            this.rating.TabIndex = 2;
            this.rating.Value = 5F;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Location = new System.Drawing.Point(4, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(9, 15);
            this.id.TabIndex = 42;
            this.id.Text = "0";
            this.id.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.picImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(511, 364);
            this.guna2Panel1.TabIndex = 43;
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
            this.btnlike.Location = new System.Drawing.Point(12, 237);
            this.btnlike.Name = "btnlike";
            this.btnlike.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnlike.Size = new System.Drawing.Size(45, 45);
            this.btnlike.TabIndex = 40;
            // 
            // Book_Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.id);
            this.Name = "Book_Crud";
            this.Size = new System.Drawing.Size(511, 364);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2PictureBox picImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public System.Windows.Forms.Label lbllike;
        public System.Windows.Forms.Label lblrating;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label lblcategory;
        public Guna.UI2.WinForms.Guna2RatingStar rating;
        private Guna.UI2.WinForms.Guna2Button upd;
        private Guna.UI2.WinForms.Guna2Button del;
        public Guna.UI2.WinForms.Guna2HtmlLabel id;
        public System.Windows.Forms.Label lblstock;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnlike;
    }
}
