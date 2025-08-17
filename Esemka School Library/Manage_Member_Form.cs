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
    public partial class Manage_Member_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        int s = -1;
        bool status;
        bool menu;
        public Manage_Member_Form()
        {
            InitializeComponent();
        }

        private void Manage_Member_Form_Load(object sender, EventArgs e)
        {
            loadDgv();
            btns(false);
            tbs(false);
            tbC();
        }

        private void btns(bool a)
        {
            ins.Visible = !a;
            upd.Visible = !a;
            del.Visible = !a;

            sav.Visible = a;
            can.Visible = a;


        }

        private void tbs(bool a)
        {
            tbname.Enabled = a;
            tbcode.Enabled = a;
        }

        private void tbC()
        {
            tbcode.Clear();
            tbname.Clear();
            tbid.Clear();
        }


        private void loadDgv()
        {
            var q = dcdc.Members.Where(x => x.Name.Contains(tbSearch.Text)).Select(x => new
            {
                x.Id,
                x.Name,
                Code = x.Password
            });

            Dgv.DataSource = q.ToList();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s = e.RowIndex;

            if (s != -1)
            {
                tbid.Text = Dgv.Rows[s].Cells[0].Value.ToString();
                tbname.Text = Dgv.Rows[s].Cells[1].Value.ToString();
                tbcode.Text = Dgv.Rows[s].Cells[2].Value.ToString();
            }
        }

        private void ins_Click(object sender, EventArgs e)
        {
            tbid.Text = "";
            tbname.Text = "";
            tbcode.Text = "";
            status = true;
            btns(true);
            tbs(true);
            tbC();
        }

        private void upd_Click(object sender, EventArgs e)
        {
            if (s != -1)
            {
                status = false;
                btns(true);
                tbs(true);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (s != -1)
            {
                DialogResult dg = MessageBox.Show("Are You Sure to Delete this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dg == DialogResult.Yes)
                {
                    Member m = dcdc.Members.Where(x => x.Id.Equals(tbid.Text)).FirstOrDefault();
                    dcdc.Members.DeleteOnSubmit(m);
                    dcdc.SubmitChanges();
                    MessageBox.Show("Delete Success");
                    loadDgv();
                    tbs(false);
                    tbC();
                    btns(false);
                    s = -1;

                }
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void can_Click(object sender, EventArgs e)
        {
            tbid.Text = "";
            tbname.Text = "";
            tbcode.Text = "";
            tbC();
            tbs(false);
           
            btns(false);
            s = -1;
        }

        private void sav_Click(object sender, EventArgs e)
        {
            if (tbcode.Text == string.Empty || tbname.Text == string.Empty)
            {
                MessageBox.Show("All must be Filled");
            }
            else
            {
                if (status)
                {
                    Member m = new Member();
                    m.Id = 1;
                    m.Name = tbname.Text;
                    m.Password = tbcode.Text;
                    dcdc.Members.InsertOnSubmit(m);
                    dcdc.SubmitChanges();
                    MessageBox.Show("Insert Success");
                    tbid.Text = "";
                    tbname.Text = "";
                    tbcode.Text = "";
                    loadDgv();
                    tbs(false);
                    tbC();
                    btns(false);
                    s = -1;
                }
                else
                {
                    Member m = dcdc.Members.Where(x => x.Id.Equals(tbid.Text)).FirstOrDefault();
                    m.Name = tbname.Text;
                    m.Password = tbcode.Text;
                    dcdc.SubmitChanges();
                    MessageBox.Show("Update Success");
                    tbid.Text = "";
                    tbname.Text = "";
                    tbcode.Text = "";
                    loadDgv();
                    tbs(false);
                    tbC();
                    btns(false);
                    s = -1;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
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
