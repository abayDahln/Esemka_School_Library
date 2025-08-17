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
    public partial class Borrowed_Book_Control : UserControl
    {
        public Borrowed_Book_Control()
        {
            InitializeComponent();
        }

        private void checkyes_Click(object sender, EventArgs e)
        {
            checkyes.Checked = !checkyes.Checked;
            Return_Confirm_Dialog r = new Return_Confirm_Dialog(Convert.ToInt32(lblid.Text), this.ParentForm as Manage_Borrowed_Books);

            r.ShowDialog();
        }
    }
}
