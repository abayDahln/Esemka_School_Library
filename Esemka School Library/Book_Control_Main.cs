using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_School_Library
{
    public partial class Book_Control_Main : UserControl
    {
        public static bool like = false;
        public Book_Control_Main()
        {
            InitializeComponent();
        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            if (like)
            {
                btnlike.Image = Properties.Resources.favorite;
                btnlike.FillColor = Color.FromArgb(250, 238, 238, 238);
                like = false;
            }
            else
            {
                btnlike.Image = Properties.Resources.favorite_fill;
                btnlike.FillColor = Color.Gainsboro;
                like = true;
            }
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(like, this.ParentForm);
            df.id.Text = id.Text;
            df.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide(); 

        }

        private void picImage_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(like, this.ParentForm);
            df.id.Text = id.Text;
            df.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(like, this.ParentForm);
            df.id.Text = id.Text;
            df.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }

        private void lblcategory_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(like, this.ParentForm);
            df.id.Text = id.Text;
            df.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }
    }
}
