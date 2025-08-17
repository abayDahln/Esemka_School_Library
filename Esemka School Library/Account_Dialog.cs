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
    public partial class Account_Dialog : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        int id;

        public Account_Dialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Account_Dialog_Load(object sender, EventArgs e)
        {
            if (DataStorage.role)
            {
                var q = dcdc.Non_Members.Where(x => x.Id == id).FirstOrDefault();

                lblNama.Text = q.Name.ToString();
                lblpw.Text = "#" + q.Password.ToString();
            }
            else
            {
                var q = dcdc.Members.Where(x => x.Id == id).FirstOrDefault();

                lblNama.Text = q.Name.ToString();
                lblpw.Text = "#" + q.Password.ToString();
            }
        }
    }
}
