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
       
    public partial class Book_Object : UserControl
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();

        Main_Form m;
        public Book_Object(Main_Form m)
        {
            InitializeComponent();
            this.m = m; 
        }

        private void Book_Object_Load(object sender, EventArgs e)
        {
            buttonC.FillColor = Color.FromArgb(50, 110, 129, 184);
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       

        

        private void categoriesName_MouseHover(object sender, EventArgs e)
        {
            buttonC.Visible = true;
        }

      

        

        private void categoriesImage_MouseHover_1(object sender, EventArgs e)
        {
            buttonC.Visible = true;
        }

        private void Book_Object_MouseHover(object sender, EventArgs e)
        {
            buttonC.Visible = true;    
        }

      

        private void buttonC_Click(object sender, EventArgs e)
        { 
            if (categoriesName.Text == "More Categories")
            {
                More_Categories_Dialog mr = new More_Categories_Dialog(m);
                mr.ShowDialog();
            }
            else
            {
                    
                    
                Search_Form s = new Search_Form();
                s.Show();
                s.cbCategories.SelectedIndex = dcdc.Categories.Where(x => x.Name.Equals(categoriesName.Text)).Select(x => x.Id).FirstOrDefault();
                   
                this.ParentForm.Hide();
                Program.formHistory.Push(m);
                m.Hide();
            }
            
        }

        private void buttonC_MouseHover(object sender, EventArgs e)
        {
            buttonC.Visible = true;
        }

        private void buttonC_MouseLeave(object sender, EventArgs e)
        {
            buttonC.Visible = false;
        }
    }
}
