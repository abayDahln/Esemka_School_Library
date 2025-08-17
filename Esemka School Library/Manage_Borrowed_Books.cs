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
    public partial class Manage_Borrowed_Books : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        bool menu;
        public Manage_Borrowed_Books()
        {
            InitializeComponent();
        }

        private void Manage_Borrowed_Books_Load(object sender, EventArgs e)
        {
            loadflow();
        }

        public void loadflow()
        {
            flow.Controls.Clear();

            var q = dcdc.Borrow_Books.Where(x => x.Member.Name.Contains(tbSearch.Text) || x.Book.Title.Contains(tbSearch.Text));

            foreach (var x in q)
            {
                Borrowed_Book_Control b = new Borrowed_Book_Control();
                b.lblid.Text = x.Id.ToString();
                DataStorage.LoadImageBook(b.picImage, x.Book);
                b.lblBookName.Text = x.Book.Title;
                b.lblMember.Text = x.Member.Name;
                b.borroweddate.Text = x.borrow_date.ToString("yyyy-MMM-dd");
                b.returndate.Text = x.book_return_date.ToString("yyyy-MMM-dd");
                if (Convert.ToBoolean(x.is_return))
                {
                    b.checkyes.Checked = true;
                    b.lblyes.Text = "Yes";
                }
                else
                {
                    b.checkyes.Checked = false;
                    b.lblyes.Text = "No";
                }
                flow.Controls.Add(b);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadflow();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelManageItems.FillColor = Color.FromArgb(55, 130, 159, 244);

            timerLeftPanel.Start();
        }

        private void timerLeftPanel_Tick(object sender, EventArgs e)
        {
            if (menu)
            {

                if (leftLeftPanel.Width > 0)
                {
                    leftLeftPanel.Width -= 20;

                }
                else
                {
                    timerLeftPanel.Stop();

                    menu = false;
                }
            }
            else
            {


                if (leftLeftPanel.Width < 240)
                {
                    leftLeftPanel.Width += 10;

                }
                else
                {
                    timerLeftPanel.Stop();
                    menu = true;

                }
            }
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
