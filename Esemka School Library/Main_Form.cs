using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace Esemka_School_Library
{
    public partial class Main_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        
        bool menu;
        int index = 0;
        string LoR;

        public Main_Form()
        {
            InitializeComponent();


            
        }

        private void Main_Form_Load(object sender, EventArgs e)
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


            btnLeft.Enabled = false;

            loadFlow();
            loadPanel();
            loadFlowBook();

        }
        private void loadPanel()
        {
            Color a = Color.FromArgb(70, 110, 129, 204);

            pHome.Visible = false;
            pCategories.Visible = false;
            pBook.Visible = false;
            pTimer.Visible = false;
            pMacc.Visible = false;
            pItem.Visible = false;

            pInfo.Visible = false;
            pAccount.Visible = false;
            pLogout.Visible = false;

            pHome.FillColor = a;
            pCategories.FillColor = a;
            pBook.FillColor = a;
            pTimer.FillColor = a;
            pMacc.FillColor = a;
            pItem.FillColor = a;

            pInfo.FillColor = a;
            pAccount.FillColor = a;
            pLogout.FillColor = a;
        }


        private void loadFlow()
        {
            flowCategories.Controls.Clear();

            var c = dcdc.Categories;

            foreach (var i in c)
            {
                if (flowCategories.Controls.Count == 8)
                {
                    Book_Object p = new Book_Object(this);
                    p.categoriesName.Text = "More Categories";
                    p.categoriesImage.Image = Properties.Resources.widgets_gray;
                    p.categoriesImage.Dock = DockStyle.None;
                    p.categoriesImage.Width = 100;
                    p.categoriesImage.Left = 30;


                    flowCategories.Controls.Add(p);
                    return;
                }

                Book_Object u = new Book_Object(this);
                u.categoriesName.Text = i.Name;
                DataStorage.LoadImage(u.categoriesImage, i);
                
                flowCategories.Controls.Add(u);
            }

            
        }

        private void loadFlowBook()
        {
            flowBook.Controls.Clear();

            var q = dcdc.Books;

            foreach (var y in q)
            {
                Book_Control_Main bc = new Book_Control_Main();
                bc.lblname.Text = y.Title;
                bc.id.Text = y.Id.ToString();
                bc.Margin = new Padding(20);
                DataStorage.LoadImageBook(bc.picImage, y);
                bc.lblcategory.Text = y.Category.Name;
                flowBook.Controls.Add(bc);

            }

            
        }
        
        private void timerLeftPanel_Tick(object sender, EventArgs e)
        {
            if (menu)
            {

                if (leftPanel.Width > 0)
                {
                    leftPanel.Width -= 20;

                }
                else
                {
                    timerLeftPanel.Stop();

                    menu = false;
                }
            }
            else
            {


                if (leftPanel.Width < 240)
                {
                    leftPanel.Width += 10;

                }
                else
                {
                    timerLeftPanel.Stop();
                    menu = true;

                }
            }
            

        }
        private void labelLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }
        private void logoLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }


        private void labelInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

      

        private void logoInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }


        private void labelAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;

        }

        private void logoAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            LoR = "Left";
            timerBook1.Start();
            timerBook2.Start();
            timerBook3.Start();
            timerBook4.Start();
            timerBook5.Start();
            timerBook7.Start();
            index--;

            timerBtn.Start();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnRight.Enabled=false;
            btnLeft.Enabled=false;
            LoR = "Right";
            timerBook1.Start();
            timerBook2.Start();
            timerBook3.Start();
            timerBook4.Start();
            timerBook5.Start();
            timerBook7.Start();
            
            index++;

            timerBtn.Start();

        }

        private void timerBook1_Tick(object sender, EventArgs e)
        {

            


            if (LoR == "Right")
            {
                if (index == 0)
                {

                }
                else if (index == 1)
                {
                    if (imageBook1.Width > 0)
                    {
                        imageBook1.Width -= 25;
                    }

                    else 
                    {
                        timerBook1.Stop();
                        timerBook1.Dispose();
                    }

                }
                else
                {
                    
                }
            }
            else
            {
                if (index == 0)
                {
                    if (imageBook1.Width < 350)
                    {
                        imageBook1.Width += 25;
                    }

                    else
                    {
                        timerBook1.Stop();
                        timerBook1.Dispose();
                    }
                }
                else if (index == 1)
                {

                }
                else
                {

                }
            }
        }

        private void timerBook2_Tick(object sender, EventArgs e)
        {
            if (LoR == "Right")
            {
                if (index == 0)
                {

                }
                else if (index == 1)
                {
                    if (imageBook2.Location.X > 100)
                    {

                        imageBook2.Left -= 25;
                    }

                    else
                    {
                        timerBook2.Stop();
                        timerBook2.Dispose();
                    }
                }
                else
                {
                    if (imageBook2.Width > 0)
                    {
                        imageBook2.Width -= 25;
                    }

                    else
                    {
                        timerBook2.Stop();
                        timerBook2.Dispose();
                    }
                }
            }
            else
            {
                if (index == 0)
                {
                    if (imageBook2.Location.X < 475)
                    {
                        imageBook2.Left += 25;
                    }
                    else
                    {
                        timerBook2.Stop();
                        timerBook2.Dispose();
                    }

                }
                else if (index == 1)
                {
                    if (imageBook2.Width < 350)
                    {
                        imageBook2.Width += 25;
                    }

                    else
                    {
                        timerBook2.Stop();
                        timerBook2.Dispose();
                    }

                }
                else
                {

                }
            }
        }

        private void timerBook3_Tick(object sender, EventArgs e)
        {
            


            if (LoR == "Right")
            {
                if (index == 0)
                {

                }
                else if (index == 1)
                {
                    if (imageBook3.Location.X > 475)
                    {

                        imageBook3.Left -= 25;
                    }

                    else
                    {
                        timerBook3.Stop();
                        timerBook3.Dispose();
                    }
                }

                else if (index == 2)
                {
                    if (imageBook3.Location.X > 100) imageBook3.Left -= 25;

                    else
                    {
                        timerBook3.Stop();
                        timerBook3.Dispose();
                    }

                }
                
            }
            else
            {
                if (index == 0)
                {
                    if (imageBook3.Location.X < 850)
                    {
                        imageBook3.Left += 25;
                    }
                    else
                    {
                        timerBook3.Stop();
                        timerBook3.Dispose();
                    }
                }
                else if (index == 1)
                {
                    if (imageBook3.Location.X < 475)
                    {
                        imageBook3.Left += 25;
                    }
                    else
                    {
                        timerBook3.Stop();
                        timerBook3.Dispose();
                    }
                }
                else
                {

                }
            }

        }

        private void timerBook4_Tick(object sender, EventArgs e)
        {
            

            if (LoR == "Right")
            {
                if (index == 0)
                {

                }
                else if (index == 1)
                {
                    if (imageBook4.Location.X > 850)
                    {

                        imageBook4.Left -= 25;
                    }

                    else
                    {
                        timerBook4.Stop();
                        timerBook4.Dispose();

                    }
                }
                else if (index == 2)
                {
                    if (imageBook4.Location.X > 475) imageBook4.Left -= 25;

                    else
                    {
                        timerBook4.Stop();
                        timerBook4.Dispose();
                    }
                }
              
            }
            else
            {
                if (index == 0)
                {
                    if (imageBook4.Location.X < 1225)
                    {
                        imageBook4.Left += 25;
                    }
                    else timerBook4.Stop();
                }
                else if (index == 1)
                {
                    if (imageBook4.Location.X < 850)
                    {
                        imageBook4.Left += 25;
                    }
                    else
                    {
                        timerBook4.Stop();
                        timerBook4.Dispose();
                    }
                }
                else
                {

                }
            }
        }

        private void timerBook5_Tick(object sender, EventArgs e)
        {
            


            if (LoR == "Right")
            {
                if (index == 0)
                {

                }
                else if (index == 1)
                {
                    timerBook6.Start();
                    if (imageBook5.Location.X > 1230) imageBook5.Left -= 25;

                    else
                    {
                        timerBook5.Stop();
                        timerBook5.Dispose();

                    }
                }
                else if (index == 2)
                {
                    if (imageBook5.Location.X > 860) imageBook5.Left -= 25;

                    else { 
                        timerBook5.Stop();
                        timerBook5.Dispose();

                    }
                }

            }
            else
            {
                if (index == 0)
                {
                    timerBook9.Start();
                    if (imageBook5.Location.X < 1600) imageBook5.Left += 25;

                    else 
                    { 
                        timerBook5.Stop();
                        timerBook5.Dispose();
                    }
                }
                else if (index == 1)
                {

                    if (imageBook5.Location.X < 1210) imageBook5.Left += 25;

                    else 
                    {
                        timerBook5.Stop();
                        timerBook5.Dispose();
                    }
                }
                else
                {

                }
            }
        }

        private void timerBook6_Tick(object sender, EventArgs e)
        {
            if (imageBook5.Width < 350)
            {
                imageBook5.Width += 25;
                
            }
            
            else
            {
                timerBook6.Stop();
                timerBook6.Dispose();
            }
        }

        private void timerBook7_Tick(object sender, EventArgs e)
        {
            if (LoR == "Right")
            {
                if (index == 0)
                {

                }
                else if (index == 1)
                {




                }
                else if (index == 2)
                {
                    timerBook8.Start();
                    if (imageBook6.Location.X > 1235) imageBook6.Left -= 25;

                    else
                    {
                        timerBook7.Stop();
                        timerBook7.Dispose();
                    }
                }

            }
            else
            {
                if (index == 0)
                {
                  
                }
                else if (index == 1)
                {
                    timerBook10.Start();
                    if (imageBook6.Location.X < 1600) imageBook6.Left += 25;

                    else
                    {
                        timerBook7.Stop();
                        timerBook7.Dispose();
                    }
                }
                else
                {

                }
            }
        }

        private void timerBook8_Tick( object sender, EventArgs e)
        {
          
            if (imageBook6.Width < 350)
            {
                imageBook6.Width += 25;
            }

            else
            {
                timerBook8.Stop();
                timerBook8.Dispose();

            }
            
        }

        private void timerBook9_Tick(object sender, EventArgs e)
        {
            if (imageBook5.Width > 0)
            {
                imageBook5.Width -= 25;
            }

            else
            {
                timerBook9.Stop();
                timerBook9.Dispose();

            }
        }

        private void timerBook10_Tick(object sender, EventArgs e)
        {
            if (imageBook6.Width > 0)
            {
                imageBook6.Width -= 25;
            }

            else
            {
                timerBook10.Stop();
                timerBook10.Dispose();

            }
        }

        private void timerBtn_Tick(object sender, EventArgs e)
        {
            if (index == 0)
            {
                btnLeft.Enabled = false;
            }
            else
            {
                btnLeft.Enabled = true;
            }

            if (index < 2)
            {
                btnRight.Enabled = true;
            }

            if (index > 0)
            {
                btnLeft.Enabled = true;
            }

            if (index == 2)
            {
                btnRight.Enabled = false;
            }
            else
            {

                btnRight.Enabled = true;
            }

            timerBtn.Stop();
            timerBtn.Dispose();
        }


        private void panelHome_Click(object sender, EventArgs e)
        {
        }

        private void pInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void pInfo_MouseLeave(object sender, EventArgs e)
        {
            pInfo.Visible = false;
        }

        private void pAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible = true;
        }

        private void pAccount_MouseLeave(object sender, EventArgs e)
        {
            pAccount.Visible = false;
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
            Login_Form f = new Login_Form();
            f.Show();
            this.Hide();
        }

        private void panelInfo_MouseMove(object sender, MouseEventArgs e)
        {
            pInfo.Visible = true;
        }

        private void panelLogout_MouseHover(object sender, EventArgs e)
        {
            pLogout.Visible = true;
        }

        private void panelAccount_MouseHover(object sender, EventArgs e)
        {
            pAccount.Visible=true;
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

        private void labelTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void panelTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void logoTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
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

        private void labelHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void logoHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void panelHome_MouseHover(object sender, EventArgs e)
        {
            pHome.Visible = true;
        }

        private void pMacc_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void pMacc_MouseLeave(object sender, EventArgs e)
        {
            pMacc.Visible = false;
        }

        private void pTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
        }

        private void pTimer_MouseLeave(object sender, EventArgs e)
        {
            pTimer.Visible = false;
        }

        private void pBook_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
        }

        private void pBook_MouseLeave(object sender, EventArgs e)
        {
            pBook.Visible = false;
        }

        private void pCategories_MouseHover(object sender, EventArgs e)
        {
            pCategories.Visible = true;
        }

        private void pCategories_MouseLeave(object sender, EventArgs e)
        {
            pCategories.Visible = false;
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

           

            timerLeftPanel.Start();
        }

        

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            Search_Form sf = new Search_Form();
            sf.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelHome.FillColor = Color.FromArgb(55, 130, 159, 244);

            timerLeftPanel.Start();
        }

        private void imageBook1_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(false, this);
            df.id.Text = "43";
            df.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void imageBook2_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(false, this);
            df.id.Text = "12";
            df.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void imageBook3_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(false, this);
            df.id.Text = "47";
            df.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void imageBook4_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(false, this);
            df.id.Text = "48";
            df.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void imageBook5_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(false, this);
            df.id.Text = "46";
            df.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void imageBook6_Click(object sender, EventArgs e)
        {
            Detail_Book_Form df = new Detail_Book_Form(false, this);
            df.id.Text = "22";
            df.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void pInfo_Click(object sender, EventArgs e)
        {
            Info_Dialog dlg = new Info_Dialog();
            dlg.ShowDialog();
        }

        private void pAccount_Click(object sender, EventArgs e)
        {
            Account_Dialog a = new Account_Dialog(DataStorage.id);
            a.ShowDialog();

        }

        private void pBook_Click(object sender, EventArgs e)
        {
            timerLeftPanel.Start();
            Search_Form f = new Search_Form();
            f.Show();
            this.Hide();
            Program.formHistory.Push(this);
        }

        private void pCategories_Click(object sender, EventArgs e)
        {
            Saved_Book_Form c = new Saved_Book_Form();
            c.ShowDialog();
            this.Hide();
        }

        private void pTimer_Click(object sender, EventArgs e)
        {
            Timer_Borrowed_Book_Form m = new Timer_Borrowed_Book_Form();
            m.Show();
            this.Hide();
        }

        private void pMacc_Click(object sender, EventArgs e)
        {
            Manage_Account_Form m = new Manage_Account_Form();
            m.Show();
            this.Hide();
        }

        private void pItem_Click(object sender, EventArgs e)
        {
            Manage_Item_Form m = new Manage_Item_Form();
            m.Show();
            this.Hide();
        }
    }
}
