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
    public partial class Book_Control : UserControl
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public bool like = false;
        public Book_Control()
        {
            InitializeComponent();
        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            if (like)
            {
                btnlike.Image = Properties.Resources.favorite;
                btnlike.FillColor = Color.FromArgb(250, 238, 238, 238);
                int angka = Convert.ToInt32(lbllike.Text.ToString().Replace(" likes", "")) - 1;
                lbllike.Text = angka.ToString() + " likes";
                like = false;
            }
            else
            {
                btnlike.Image = Properties.Resources.favorite_fill;
                btnlike.FillColor = Color.Gainsboro;
                int angka = Convert.ToInt32(lbllike.Text.ToString().Replace(" likes", "")) + 1;
                lbllike.Text = angka.ToString() + " likes";
                like = true;
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            Detail_Book_Form db = new Detail_Book_Form(like, this.ParentForm);
            db.id.Text = id.Text;
            
            db.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            Detail_Book_Form db = new Detail_Book_Form(like, this.ParentForm);
            db.id.Text = id.Text;
            db.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }

        private void lblcategory_Click(object sender, EventArgs e)
        {
            Detail_Book_Form db = new Detail_Book_Form(like, this.ParentForm);
            db.id.Text = id.Text;
            db.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }

        private void rating_Click(object sender, EventArgs e)
        {
        }

        

        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            Detail_Book_Form db = new Detail_Book_Form(like, this.ParentForm);
            db.id.Text = id.Text;
            db.Show();
            Program.formHistory.Push(this.ParentForm);
            this.ParentForm.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataStorage.role)
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Non_Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    Saved_Book s = new Saved_Book();
                    s.Book_Id = Convert.ToInt32(id.Text);
                    s.Non_Member_Id = DataStorage.id;
                    s.id = 1;
                    dcdc.Saved_Books.InsertOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
                else
                {
                    Saved_Book s = q;
                    dcdc.Saved_Books.DeleteOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark;
                }
            }
            else
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    Saved_Book s = new Saved_Book();
                    s.Book_Id = Convert.ToInt32(id.Text);
                    s.Member_Id = DataStorage.id;
                    s.id = 1;
                    dcdc.Saved_Books.InsertOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
                else
                {
                    Saved_Book s = q;
                    dcdc.Saved_Books.DeleteOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark;
                }
              
            }
        }

        private void Book_Control_Load(object sender, EventArgs e)
        {
            if (DataStorage.role)
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Non_Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    btnSave.Image= Properties.Resources.bookmark;
                }
                else
                {
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
            }
            else
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    btnSave.Image = Properties.Resources.bookmark;
                }
                else
                {
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
            }
        }
    }
}
