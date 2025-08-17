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
    public partial class Manage_Books_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        bool menu;
        public Manage_Books_Form()
        {
            InitializeComponent();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadflow();
        }

        private void Manage_Books_Form_Load(object sender, EventArgs e)
        {
            loadflow();
        }
        private void loadflow()
        {
            flow.Controls.Clear();

            var r = dcdc.Books.Where(x => x.Title.Contains(tbSearch.Text) || x.Category.Name.Contains(tbSearch.Text));


            foreach (var item in r)
            {
                Book_Crud bc = new Book_Crud();
                bc.Margin = new Padding(15);
                bc.lblname.Text = item.Title;
                bc.lblcategory.Text = item.Category.Name;
                bc.id.Text = item.Id.ToString();
                bc.rating.Value = item.Rating;
                bc.lblrating.Text = "( " + item.Rating.ToString() + " )";
                bc.lbllike.Text = item.Likes.ToString() + " likes";
                bc.lblstock.Text = "Stock: " + item.Stock.ToString();
                DataStorage.LoadImageBook(bc.picImage, item);

                flow.Controls.Add(bc);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Book_Dialog b = new Book_Dialog(this);
            b.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Program.formHistory.Count > 0)
            {
                Form previousForm = Program.formHistory.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

       
    }
}
