namespace Esemka_School_Library
{
    partial class Categories_Crud
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
            this.nameCategories = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.imageCategories = new Guna.UI2.WinForms.Guna2PictureBox();
            this.upd = new Guna.UI2.WinForms.Guna2Button();
            this.del = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // nameCategories
            // 
            this.nameCategories.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCategories.Location = new System.Drawing.Point(182, 52);
            this.nameCategories.Name = "nameCategories";
            this.nameCategories.Size = new System.Drawing.Size(201, 96);
            this.nameCategories.TabIndex = 36;
            this.nameCategories.Text = "Adventure";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(352, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(57, 63);
            this.id.TabIndex = 38;
            this.id.Text = "1";
            this.id.Visible = false;
            // 
            // imageCategories
            // 
            this.imageCategories.BackColor = System.Drawing.Color.Transparent;
            this.imageCategories.BorderRadius = 12;
            this.imageCategories.ImageRotate = 0F;
            this.imageCategories.Location = new System.Drawing.Point(24, 20);
            this.imageCategories.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imageCategories.Name = "imageCategories";
            this.imageCategories.Size = new System.Drawing.Size(150, 150);
            this.imageCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageCategories.TabIndex = 0;
            this.imageCategories.TabStop = false;
            this.imageCategories.UseTransparentBackground = true;
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
            this.upd.Location = new System.Drawing.Point(38, 182);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(148, 44);
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
            this.del.Location = new System.Drawing.Point(223, 182);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(151, 44);
            this.del.TabIndex = 52;
            this.del.Text = "Delete";
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Categories_Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nameCategories);
            this.Controls.Add(this.imageCategories);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Categories_Crud";
            this.Size = new System.Drawing.Size(409, 254);
            this.Load += new System.EventHandler(this.Categories_Crud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2PictureBox imageCategories;
        public System.Windows.Forms.Label nameCategories;
        public System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2Button upd;
        private Guna.UI2.WinForms.Guna2Button del;
    }
}
