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
    public partial class Login_Form : Form
    {
        int index = 0;
        int x = -1;
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rBtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            
            


        }

       

       
        

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {


                if (index == 0)
                {
                    background.Image = Properties.Resources.w2;
                    index++;


                }
                else if (index == 1)
                {
                    background.Image = Properties.Resources.w3;
                    index++;


                }
                else
                {
                    background.Image = Properties.Resources.w1;
                    index = 0;


                }
            }
            catch 
            { 
            
            }
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty || cbRole.Text == "" || cbUsername.Text == "")
            {
                MessageBox.Show("All Must be Filled");
            }

            else
            {
                if (cbRole.SelectedIndex == 0)
                {
                    var q = dcdc.Non_Members.Where(x => x.Name.Equals(cbUsername.Text) && x.Password.Equals(tbPassword.Text)).FirstOrDefault();

                    if (q != null)
                    {
                        DataStorage.id = q.Id;
                        DataStorage.role = true;
                        Main_Form mf = new Main_Form();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
                else if (cbRole.SelectedIndex == 1)
                {
                    var q = dcdc.Members.Where(x => x.Name.Equals(cbUsername.Text) && x.Password.Equals(tbPassword.Text)).FirstOrDefault();

                    if (q != null)
                    {
                        DataStorage.id = q.Id;
                        DataStorage.role = false;
                        Main_Form mf = new Main_Form();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
            }







            //Main_Form mf = new Main_Form();
            //mf.Show();
            //this.Hide();
        }

        

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = cbRole.SelectedIndex;
            cbUsername.DataSource = null;
        }

        private void loadmem()
        {
            cbUsername.DataSource = null;

            var x = dcdc.Members;

            cbUsername.DataSource = x;
            cbUsername.ValueMember = "Id";
            cbUsername.DisplayMember = "Name";

            cbUsername.Text = "";

        }

        private void loadnon()
        {
            cbUsername.DataSource = null;

            var x = dcdc.Non_Members;

            cbUsername.DataSource = x;
            cbUsername.ValueMember = "Id";
            cbUsername.DisplayMember = "Name";
            cbUsername.Text = "";

        }

        private void cbUsername_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                loadnon();
                cbUsername.Text = "";
            }
            else if (x == 1)
            {
                loadmem();
                cbUsername.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
