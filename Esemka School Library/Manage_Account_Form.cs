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
    public partial class Manage_Account_Form : Form
    {
        bool menu;
        public Manage_Account_Form()
        {
            InitializeComponent();
        }

        private void nonicon_MouseHover(object sender, EventArgs e)
        {
            nonP.Visible = true;
        }

        private void nonlbl_MouseHover(object sender, EventArgs e)
        {
            nonP.Visible = true; 
        }

        private void nonpanel_MouseHover(object sender, EventArgs e)
        {
            nonP.Visible= true;
        }

        private void nonP_MouseHover(object sender, EventArgs e)
        {
            nonP.Visible = true;
        }

        private void nonP_MouseLeave(object sender, EventArgs e)
        {
            nonP.Visible = false;
        }

        private void nonP_Click(object sender, EventArgs e)
        {
            Manage_Non_Member_Form m = new Manage_Non_Member_Form();
            m.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void icon_MouseHover(object sender, EventArgs e)
        {
            p.Visible = true;
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            p.Visible= true;
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            p.Visible=true;
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
            p.Visible = true;
        }

        private void p_MouseLeave(object sender, EventArgs e)
        {
            p.Visible = false;
        }

        private void p_Click(object sender, EventArgs e)
        {
            Manage_Member_Form m = new Manage_Member_Form();
            m.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void Manage_Account_Form_Load(object sender, EventArgs e)
        {
            loadPanel();

            p.FillColor = Color.FromArgb(80, 176, 196, 222);
            nonP.FillColor = Color.FromArgb(80, 176, 196, 222);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible= true;
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
            Info_Dialog f = new Info_Dialog();
            f.ShowDialog();
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

        private void pMacc_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void pMacc_MouseLeave(object sender, EventArgs e)
        {
            pMacc.Visible = false;
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

        private void pMacc_Click(object sender, EventArgs e)
        {
            timerLeftPanel.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelManageAccount.FillColor = Color.FromArgb(55, 130, 159, 244);

            timerLeftPanel.Start();
        }
        private void loadPanel()
        {
            Color a = Color.FromArgb(70, 110, 129, 204);

            pHome.Visible = false;
            pCategories.Visible = false;
            pBook.Visible = false;
            pMacc.Visible = false;
            pItem.Visible = false;

            pInfo.Visible = false;
            pAccount.Visible = false;
            pLogout.Visible = false;

            pHome.FillColor = a;
            pCategories.FillColor = a;
            pBook.FillColor = a;
            pMacc.FillColor = a;
            pItem.FillColor = a;

            pInfo.FillColor = a;
            pAccount.FillColor = a;
            pLogout.FillColor = a;
        }

        private void pCategories_MouseHover(object sender, EventArgs e)
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

        private void panelCategories_MouseHover(object sender, EventArgs e)
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

        private void pBook_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
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

        private void pHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void panelHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void logoHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void labelHome_MouseHover(object sender, EventArgs e)
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
    }
}
