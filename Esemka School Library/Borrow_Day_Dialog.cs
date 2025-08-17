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
    public partial class Borrow_Day_Dialog : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        int id;
        public Borrow_Day_Dialog(int id)
        {
            InitializeComponent();
            this.id = id;   
        }

        private void Borrow_Day_Dialog_Load(object sender, EventArgs e)
        {
            loadFlow();
        }
        private void loadFlow()
        {
            var q = dcdc.Borrow_Categories;

            foreach (var c in q)
            {
                Day_Control d = new Day_Control();
                d.btnDay.Text = c.Category;
                d.id = id;
                flowLayoutPanel1.Controls.Add(d);

            }

          
        }
    }
}
