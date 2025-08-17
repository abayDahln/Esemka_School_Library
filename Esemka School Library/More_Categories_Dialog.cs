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
    public partial class More_Categories_Dialog : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        Main_Form m;
        public More_Categories_Dialog(Main_Form m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void More_Categories_Dialog_Load(object sender, EventArgs e)
        {
            loadFlow();
        }

        private void loadFlow()
        {
            flow.Controls.Clear();

            var c = dcdc.Categories;

            foreach (var i in c)
            {
                Book_Object u = new Book_Object(m);
                u.categoriesName.Text = i.Name;
                DataStorage.LoadImage(u.categoriesImage, i);

                flow.Controls.Add(u);
            }
        }
    }
}
