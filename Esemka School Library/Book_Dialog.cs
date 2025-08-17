using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Esemka_School_Library.Categories_Dialog;

namespace Esemka_School_Library
{
    public partial class Book_Dialog : Form
    {   
        int Id;
        Manage_Books_Form manage;
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public Book_Dialog(Manage_Books_Form manage, int id = 0)
        {
            InitializeComponent();
            Id = id;
            this.manage = manage;
        }

        private void Book_Dialog_Load(object sender, EventArgs e)
        {
            loadcb();
            tbLike.ShortcutsEnabled = false;
            tbYear.ShortcutsEnabled = false;
            tbStock.ShortcutsEnabled = false;
            tbRating.ShortcutsEnabled = false;
            

            tbSyn.ScrollBars = ScrollBars.Both;
            if (Id != 0)
            {
                loadData();
            }
        }
        private void loadData()
        {
            loadcb();

            var q = dcdc.Books.Where(x => x.Id == Id).FirstOrDefault();

            tbTit.Text = q.Title;
            tbSyn.Text = q.Synopsis;
            tbWri.Text = q.Writer;
            cbC.SelectedValue = q.Categories_Id;
            tbLike.Text = q.Likes.ToString();
            tbRating.Text = q.Rating.ToString();
            tbStock.Text = q.Stock.ToString();
            tbYear.Text = q.Publication_Year.ToString();
            DataStorage.LoadImageBook(picImage, q);
        }
        private void loadcb()
        {
            cbC.DataSource = dcdc.Categories;
            cbC.ValueMember = "Id";
            cbC.DisplayMember = "Name";
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            tbYear.Text = new string(tbYear.Text.Where(char.IsDigit).ToArray());
        }

        private void tbRating_TextChanged(object sender, EventArgs e)
        {
            tbRating.Text = new string(tbRating.Text.Where(char.IsDigit).ToArray());
        }

        private void tbLike_TextChanged(object sender, EventArgs e)
        {
            tbLike.Text = new string(tbLike.Text.Where(char.IsDigit).ToArray());
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {
            tbStock.Text = new string(tbStock.Text.Where(char.IsDigit).ToArray());
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (tbStock.Text == string.Empty)
            {
                tbStock.Text = "1";
            }
            else if (Convert.ToInt32(tbStock.Text) >= 0)
            {
                int x = Convert.ToInt32(tbStock.Text) + 1;
                tbStock.Text = x.ToString();
            }


        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (tbStock.Text == string.Empty)
            {
                tbStock.Text = "0";
            }
            else if (Convert.ToInt32(tbStock.Text) >= 1)
            {
                int x = Convert.ToInt32(tbStock.Text) - 1;
                tbStock.Text = x.ToString();
            }


            
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.JPEG|*.jpeg|*JPG|*.jpg|*.PNG|*.png|All File(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                picImage.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbSyn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbSyn.AppendText(Environment.NewLine); 
                e.SuppressKeyPress = true; 
            }
        }

        private void cbC_Click(object sender, EventArgs e)
        {
           
        }


        private void sav_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (Id == 0)
                {
                    Book b = new Book();
                    b.Id = 1;
                    b.Title = tbTit.Text.ToString();
                    b.Synopsis = tbSyn.Text.ToString();
                    b.Writer = tbWri.Text.ToString();
                    b.Publication_Year = Convert.ToInt32(tbYear.Text);
                    b.Categories_Id = Convert.ToInt32(cbC.SelectedValue);
                    b.Rating = Convert.ToInt32(tbRating.Text);
                    b.Likes = Convert.ToInt32(tbLike.Text);
                    b.Stock = Convert.ToInt32(tbStock.Text);
                    b.Image = DataStorage.ImageToByteArray(picImage.Image);
                    dcdc.Books.InsertOnSubmit(b);
                    dcdc.SubmitChanges();
                    MessageBox.Show("Add Success", "Ingfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Manage_Books_Form m = new Manage_Books_Form();
                    m.Show();
                    manage.Hide();
                }
                else
                {
                    Book b = dcdc.Books.Where(x => x.Id == Id).FirstOrDefault();

                    b.Title = tbTit.Text.ToString();
                    b.Synopsis = tbSyn.Text.ToString();
                    b.Writer = tbWri.Text.ToString();
                    b.Publication_Year = Convert.ToInt32(tbYear.Text);
                    b.Categories_Id = Convert.ToInt32(cbC.SelectedValue);
                    b.Rating = Convert.ToInt32(tbRating.Text);
                    b.Likes = Convert.ToInt32(tbLike.Text);
                    b.Stock = Convert.ToInt32(tbStock.Text);
                    b.Image = DataStorage.ImageToByteArray(picImage.Image);
                    dcdc.SubmitChanges();
                    MessageBox.Show("Update Success", "Ingfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Manage_Books_Form m = new Manage_Books_Form();
                    m.Show();
                    manage.Hide();
                }
            }
        }

        private bool validate()
        {
            if (tbTit.Text == string.Empty || tbSyn.Text == string.Empty || tbWri.Text == string.Empty || tbRating.Text == string.Empty || tbYear.Text == string.Empty || tbStock.Text == string.Empty|| tbLike.Text == string.Empty || picImage.Image == null)
            {

                MessageBox.Show("All Must be fill");
                return false;
            }
            else if (Convert.ToInt32(tbRating.Text) < 0 || Convert.ToInt32(tbRating.Text) > 5 )
            {
                MessageBox.Show("Rating Value Only 0-5");
                return false;
            }
            else 
            {
                return true;
            }
            
        }

        
    }
}
