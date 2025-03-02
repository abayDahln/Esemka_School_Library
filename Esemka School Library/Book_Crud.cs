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
    public partial class Book_Crud : UserControl
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public Book_Crud()
        {
            InitializeComponent();
       
        }

        private void upd_Click(object sender, EventArgs e)
        {
            Book_Dialog b = new Book_Dialog(this.ParentForm as Manage_Books_Form,Convert.ToInt32(id.Text));
            b.ShowDialog();
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are You sure to Delete This?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Book b = dcdc.Books.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                dcdc.Books.DeleteOnSubmit(b);
                dcdc.SubmitChanges();
                MessageBox.Show("Delete Success", "Ingfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
