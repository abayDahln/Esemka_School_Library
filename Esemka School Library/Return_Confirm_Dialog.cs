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
    public partial class Return_Confirm_Dialog : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        int id;
        Manage_Borrowed_Books a;
        public Return_Confirm_Dialog(int id, Manage_Borrowed_Books a)
        {
            InitializeComponent();
            this.id = id;
            this.a = a;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Borrow_Book b = dcdc.Borrow_Books.Where(x => x.Id == id).FirstOrDefault();
            b.is_return = "false";
            dcdc.SubmitChanges();
            a.loadflow();
            this.Close();
            Manage_Borrowed_Books m = new Manage_Borrowed_Books();
            m.Show();
            a.Hide();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Borrow_Book b = dcdc.Borrow_Books.Where(x => x.Id == id).FirstOrDefault();
            b.is_return = "true";
            dcdc.SubmitChanges();
            a.loadflow();
            this.Close();
            Manage_Borrowed_Books m = new Manage_Borrowed_Books();
            m.Show();
            a.Hide();
        }
    }
}
