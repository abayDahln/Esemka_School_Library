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
    public partial class Saved_Book_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        bool menu;
        public Saved_Book_Form()
        {
            InitializeComponent();
        }

        private void Saved_Book_Form_Load(object sender, EventArgs e)
        {
            if (DataStorage.role)
            {

                panelBackTimer.Visible = false;
                panelBackMit.Visible = true;
                panelBackMacc.Visible = true;
            }
            else
            {

                panelBackTimer.Visible = true;
                panelBackMit.Visible = false;
                panelBackMacc.Visible = false;

            }

            loadPanel();
            loadflow();
        }
        private void loadflow()
        {
            flow.Controls.Clear();


            if (DataStorage.role)
            {
                var q = dcdc.Saved_Books.Where(x => x.Non_Member_Id == DataStorage.id).Select(x => x.Book_Id);
                foreach (var i in q)
                {
                    var w = dcdc.Books.Where(x => x.Id == i).FirstOrDefault();

                    Book_Control_Main bc = new Book_Control_Main();
                    bc.lblname.Text = w.Title;
                    bc.id.Text = w.Id.ToString();
                    bc.Margin = new Padding(10);
                    DataStorage.LoadImageBook(bc.picImage, w);
                    bc.lblcategory.Text = w.Category.Name;
                    flow.Controls.Add(bc);

                }
            }
            else
            {
                var q = dcdc.Saved_Books.Where(x => x.Member_Id == DataStorage.id).Select(x => x.Book_Id);

                foreach (var i in q)
                {
                    var w = dcdc.Books.Where(x => x.Id == i).FirstOrDefault();

                    Book_Control_Main bc = new Book_Control_Main();
                    bc.lblname.Text = w.Title;
                    bc.id.Text = w.Id.ToString();
                    bc.Margin = new Padding(10);
                    DataStorage.LoadImageBook(bc.picImage, w);
                    bc.lblcategory.Text = w.Category.Name;
                    flow.Controls.Add(bc);

                }
                
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelCategories.FillColor = Color.FromArgb(55, 130, 159, 244);

            timerLeftPanel.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pLogout_MouseHover(object sender, EventArgs e)
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
            Info_Dialog m = new Info_Dialog();
            m.ShowDialog();
        }

        private void pItem_MouseHover(object sender, EventArgs e)
        {
            pItem.Visible = true;
        }

        private void panelManageItems_MouseHover(object sender, EventArgs e)
        {
            pItem.Visible = true;
        }

        private void labelManageItems_MouseHover(object sender, EventArgs e)
        {
            pItem.Visible = true;
        }

        private void logoManageItem_MouseHover(object sender, EventArgs e)
        {
            pItem.Visible = true;
        }

        private void pItem_MouseLeave(object sender, EventArgs e)
        {
            pItem.Visible = false;
        }

        private void pItem_Click(object sender, EventArgs e)
        {
            Manage_Item_Form m = new Manage_Item_Form();
            m.Show();
            this.Hide();
        }

        private void pMacc_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void pMacc_MouseLeave(object sender, EventArgs e)
        {
            pMacc.Visible = false;
        }

        private void labelManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void logoManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void panelManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void pMacc_Click(object sender, EventArgs e)
        {
            Manage_Account_Form a = new Manage_Account_Form();
            a.Show();
            this.Hide();
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
            Timer_Borrowed_Book_Form m = new Timer_Borrowed_Book_Form();
            m.Show();
            this.Hide();
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
            timerLeftPanel.Start();
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

        private void pBook_MouseLeave(object sender, EventArgs e)
        {
            pBook.Visible = false;
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
            pMacc.Visible = false;
            pItem.Visible = false;
            pTimer.Visible = false;

            pInfo.Visible = false;
            pAccount.Visible = false;
            pLogout.Visible = false;

            pHome.FillColor = a;
            pCategories.FillColor = a;
            pBook.FillColor = a;
            pMacc.FillColor = a;
            pItem.FillColor = a;
            pTimer.FillColor = a;

            pInfo.FillColor = a;
            pAccount.FillColor = a;
            pLogout.FillColor = a;
        }
    }
}
