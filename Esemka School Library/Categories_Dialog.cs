using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_School_Library
{
    public partial class Categories_Dialog : Form
    {
        public int id = 0;
        DataClassesDataContext dcdc = new DataClassesDataContext();
        Manage_Categories_Form form;
        bool a;
        public Categories_Dialog(Manage_Categories_Form c, bool a)
        {
            InitializeComponent();
            this.form = c;
            this.a = a;
        }

        private void Categories_Dialog_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var q = dcdc.Categories.Where(x => x.Id.Equals(id)).FirstOrDefault();
                tbName.Text = q.Name;
                DataStorage.LoadImage(picImage, q);
            }

            lblid.Text = id.ToString(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Image";
            openFileDialog1.Filter = "*.JPEG|*.jpeg|*JPG|*.jpg|*.PNG|*.png|All File(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                picImage.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sav_Click(object sender, EventArgs e)
        {
            if (picImage.Image == null)
            {
                MessageBox.Show("Please select an Image");
                return;
            }
            else if (tbName.Text == string.Empty)
            {
                MessageBox.Show("Name must be filled");
                return;
            }


            try
            {
                if (a)
                {
                    Category c = new Category();
                    c.Name = tbName.Text;
                    c.Image = DataStorage.ImageToByteArray(picImage.Image);
                    dcdc.Categories.InsertOnSubmit(c);
                    dcdc.SubmitChanges();
                    MessageBox.Show("Add Success");

                    this.Close();
                    form.loadflow();

                }
                else
                {
                    Category c = dcdc.Categories.Where(x => x.Id.Equals(lblid.Text)).FirstOrDefault();
                    c.Name = tbName.Text;
                    c.Image = DataStorage.ImageToByteArray(picImage.Image);
                    dcdc.SubmitChanges();
                    MessageBox.Show("Edit Success");

                    this.Close();
                    Manage_Categories_Form m = new Manage_Categories_Form();
                    m.Show();
                    form.Hide();


                }

            }
            catch
            {

            }
        }

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
