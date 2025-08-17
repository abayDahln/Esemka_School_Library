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
    public partial class Categories_Crud : UserControl
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public Form ParentFormReference { get; set; }
        public Categories_Crud()
        {
            InitializeComponent();
        }

       

        private void Categories_Crud_Load(object sender, EventArgs e)
        {

        }

        private void upd_Click(object sender, EventArgs e)
        {
            Manage_Categories_Form parentForm = this.ParentForm as Manage_Categories_Form;
            if (parentForm != null)
            {
                Categories_Dialog cd = new Categories_Dialog(parentForm, false);
                cd.id = Convert.ToInt32(id.Text);
                cd.ShowDialog(this);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are You sure to delete this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                Category c = dcdc.Categories.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                dcdc.Categories.DeleteOnSubmit(c);
                dcdc.SubmitChanges();
                MessageBox.Show("Delete Success");

                Manage_Categories_Form f = this.ParentForm as Manage_Categories_Form;
                f.loadflow();
            }
        }
    }
}
