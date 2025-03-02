using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Esemka_School_Library
{
    public partial class Manage_Categories_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        bool menu;
        public Manage_Categories_Form()
        {
            InitializeComponent();
        }

        private void Manage_Categories_From_Load(object sender, EventArgs e)
        {
            loadflow();
        }

        public void loadflow()
        {
            flow.Controls.Clear();

            var q = dcdc.Categories.Where(x => x.Name.Contains(tbSearch.Text));

            foreach (var c in q)
            {
                Categories_Crud cc = new Categories_Crud();

                cc.id.Text = c.Id.ToString();

                var z = dcdc.Categories.Where(x => x.Id == c.Id).Select(x => x.Name).FirstOrDefault();

                cc.nameCategories.Text = z.ToString();
                
               

                var o = dcdc.Categories.Where(x => x.Id == Convert.ToInt32(c.Id)).FirstOrDefault();
                
                DataStorage.LoadImage(cc.imageCategories, o);

                cc.ParentFormReference = this;
                flow.Controls.Add(cc);
            }
        }
        



       

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadflow();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Categories_Dialog dg = new Categories_Dialog(this, true);
            dg.ShowDialog(this);
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void guna2Button1_Click(object sender, EventArgs e)
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
