using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_School_Library
{
    public partial class Timer_Borrowed_Book_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        bool menu;
        public Timer_Borrowed_Book_Form()
        {
            InitializeComponent();
        }

        private void Timer_Borrowed_Book_Form_Load(object sender, EventArgs e)
        {
            loadFlow();
            loadPanel();
        }
        private void loadFlow()
        {
            flow.Controls.Clear();

            var q = dcdc.Borrow_Books.Where(x => x.member_Id == DataStorage.id && x.is_return == "false");

            foreach ( var x in q)
            {
                Timer_Book_Control t = new Timer_Book_Control();
                DataStorage.LoadImageBook(t.picImage, x.Book);
                t.lblBookName.Text = x.Book.Title;
                t.lblid.Text = x.Id.ToString();
                t.borroweddate.Text = x.borrow_date.ToString("dd-MMM-yyyy");

                //int duration = Convert.ToInt32(Convert.ToInt32(x.book_return_date.ToString("dd")) - Convert.ToInt32(x.borrow_date.ToString("dd")));

                int sisa = (x.book_return_date - DateTime.Now).Days;

                t.remainingtime.Text = sisa >= 0 ? sisa + " Day" : "0 Day";

                if (sisa == 1)
                {
                    t.panelControl.FillColor = Color.FromArgb(255, 229, 204);
                    t.lblstatus.Text = "Please Return it Tomorrow";
                }
                else if (sisa == 0)
                {
                    t.panelControl.FillColor = Color.FromArgb(254, 204, 203);
                    t.lblstatus.Text = "Please Return it Immediately (Late Return)";

                } 
                else
                {
                    t.panelControl.FillColor = Color.Azure;
                    t.lblstatus.Text = "Please Return it by " + x.book_return_date.ToString("dd-MMM-yyyy");
                }

                flow.Controls.Add(t);
            }

            if (flow.Controls.Count == 0)
            {
                lblNot.Visible = true;
            }
            else
            {
                lblNot.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelTimer.FillColor = Color.FromArgb(55, 130, 159, 244);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void panelLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void labelLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void logoLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void pLogout_MouseLeave(object sender, EventArgs e)
        {
            pLogout.Visible = false;
        }

        private void pLogout_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Show();
            this.Hide();
        }

        private void panelAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void labelAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void logoAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void pAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void pAccount_MouseLeave(object sender, EventArgs e)
        {
            pAccount.Visible = false;
        }

        private void pAccount_Click(object sender, EventArgs e)
        {
            Account_Dialog a = new Account_Dialog(DataStorage.id);
            a.ShowDialog();
        }

        private void panelInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void labelInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void logoInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void pInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void pInfo_MouseLeave(object sender, EventArgs e)
        {
            pInfo.Visible = false;
        }

        private void pInfo_Click(object sender, EventArgs e)
        {
            Info_Dialog a = new Info_Dialog();
            a.ShowDialog();
        }

        private void panelTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void labelTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void logoTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void pTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void pTimer_MouseLeave(object sender, EventArgs e)
        {
            pTimer.Visible = false;
        }

        private void pTimer_Click(object sender, EventArgs e)
        {
            timerLeftPanel.Start();
        }

        private void panelCategories_MouseHover(object sender, EventArgs e)
        {
            pCategories.Visible = true;
        }

        private void labelCategories_MouseHover(object sender, EventArgs e)
        {
            pCategories.Visible = true;
        }

        private void logoCategories_MouseHover(object sender, EventArgs e)
        {
            pCategories.Visible = true;
        }

        private void pCategories_MouseHover(object sender, EventArgs e)
        {
            pCategories.Visible = true;
        }

        private void pCategories_MouseLeave(object sender, EventArgs e)
        {
            pCategories.Visible = false;
        }

        private void pCategories_Click(object sender, EventArgs e)
        {
            Saved_Book_Form s = new Saved_Book_Form();  
            s.Show();
            this.Hide();
        }

        private void panelBooks_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
        }

        private void labelBooks_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
        }

        private void logoBooks_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
        }

        private void pBook_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
        }

        private void pBook_Click(object sender, EventArgs e)
        {
            Search_Form s = new Search_Form();
            s.Show();
            this.Hide();
        }

        private void panelHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void labelHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void logoHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void pHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void pHome_MouseLeave(object sender, EventArgs e)
        {
            pHome.Visible = false;
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            Main_Form m = new Main_Form();
            m.Show();
            this.Hide();
        }

        private void loadPanel()
        {
            Color a = Color.FromArgb(70, 110, 129, 204);

            pHome.Visible = false;
            pCategories.Visible = false;
            pBook.Visible = false;
          
            pTimer.Visible = false;

            pInfo.Visible = false;
            pAccount.Visible = false;
            pLogout.Visible = false;

            pHome.FillColor = a;
            pCategories.FillColor = a;
            pBook.FillColor = a;
         
            pTimer.FillColor = a;

            pInfo.FillColor = a;
            pAccount.FillColor = a;
            pLogout.FillColor = a;
        }

        private void pBook_MouseLeave(object sender, EventArgs e)
        {
            pBook.Visible = false;
        }
    }
}
