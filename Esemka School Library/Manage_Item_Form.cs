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
    public partial class Manage_Item_Form : Form
    {
        bool menu;
        public Manage_Item_Form()
        {
            InitializeComponent();
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

        private void Manage_Item_Form_Load(object sender, EventArgs e)
        {
            panelmB.FillColor = Color.FromArgb(80, 176, 196, 222);
            panelMc.FillColor = Color.FromArgb(80, 176, 196, 222);
            panelMbor.FillColor = Color.FromArgb(80, 176, 196, 222);

            loadPanel();
        }

        private void labelLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void logoLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void panelLogout_MouseHover(object sender, EventArgs e)
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

        private void labelAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void logoAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void panelAccount_MouseHover(object sender, EventArgs e)
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

        private void labelInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void logoInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void panelInfo_MouseHover(object sender, EventArgs e)
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
            Info_Dialog i = new Info_Dialog();
            i.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_MouseHover(object sender, EventArgs e)
        {
            panelmB.Visible = true;
        }

        private void guna2HtmlLabel2_MouseHover(object sender, EventArgs e)
        {
            panelmB.Visible=true;
        }

        private void guna2Panel5_MouseHover(object sender, EventArgs e)
        {
            panelmB.Visible = true;
        }

        private void panelmB_MouseHover(object sender, EventArgs e)
        {
            panelmB.Visible = true;
        }

        private void panelmB_MouseLeave(object sender, EventArgs e)
        {
            panelmB.Visible = false;
        }

        private void panelmB_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox3_MouseHover(object sender, EventArgs e)
        {
            panelMc.Visible = true;
        }

        private void lblWriter_MouseHover(object sender, EventArgs e)
        {
            panelMc.Visible=true;
        }

        private void guna2Panel2_MouseHover(object sender, EventArgs e)
        {
            panelMc.Visible=true;
        }

        private void panelMc_MouseHover(object sender, EventArgs e)
        {
            panelMc.Visible = true;
        }

        private void panelMc_MouseLeave(object sender, EventArgs e)
        {
            panelMc.Visible = false;
        }

        private void panelMc_Click(object sender, EventArgs e)
        {
            Manage_Categories_Form m = new Manage_Categories_Form();
            m.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void guna2PictureBox2_MouseHover(object sender, EventArgs e)
        {
            panelMbor.Visible = true;
        }

        private void guna2HtmlLabel1_MouseHover(object sender, EventArgs e)
        {
            panelMbor.Visible = true;
        }

        private void guna2Panel4_MouseHover(object sender, EventArgs e)
        {
            panelMbor.Visible=true;
        }

        private void panelMbor_MouseHover(object sender, EventArgs e)
        {
            panelMbor.Visible = true;
        }

        private void panelMbor_MouseLeave(object sender, EventArgs e)
        {
            panelMbor.Visible = false;
        }

        private void panelMbor_Click(object sender, EventArgs e)
        {
            Manage_Borrowed_Books m = new Manage_Borrowed_Books();
            m.Show();
            this.Hide();
            Program.formHistory.Push(this);
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

        private void pItem_MouseHover(object sender, EventArgs e)
        {
            pItem.Visible = true;
        }

        private void pItem_MouseLeave(object sender, EventArgs e)
        {
            pItem.Visible = false;
        }

        private void pItem_Click(object sender, EventArgs e)
        {
            timerLeftPanel.Start();
        }

        private void labelManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void panelManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void logoManageAccount_MouseHover(object sender, EventArgs e)
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

        private void pMacc_Click(object sender, EventArgs e)
        {
            Manage_Account_Form a = new Manage_Account_Form();
            a.Show();
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

        private void pHome_MouseHover(object sender, EventArgs e)
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

        private void pHome_MouseLeave(object sender, EventArgs e)
        {
            pHome.Visible = false;
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            Search_Form s = new Search_Form();
            s.Show();
            this.Hide();
        }
    }
}
