using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Esemka_School_Library
{
    public partial class Search_Form : Form
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        bool menu; 
        public Search_Form()
        {
            InitializeComponent();
        }

        private void Search_Form_Load(object sender, EventArgs e)
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

            loadcbcategoties();

            loadFlow();
            loadPanel();
        }

        private void loadFlow()
        {
            flow.Controls.Clear();

            if (tbSearch.Text == string.Empty)
            {
                if (cbCategories.Text == "All")
                {
                    lblNot.Visible = false;
                    var r = dcdc.Books;


                    foreach (var item in r)
                    {
                        Book_Control bc = new Book_Control();
                        bc.Margin = new Padding(15);
                        bc.lblname.Text = item.Title;
                        bc.lblcategory.Text = item.Category.Name;
                        bc.id.Text = item.Id.ToString();
                        bc.rating.Value = item.Rating;
                        bc.lblrating.Text = "( " + item.Rating.ToString() + " )";
                        bc.lbllike.Text = item.Likes.ToString() + " likes";
                        DataStorage.LoadImageBook(bc.picImage, item);

                        flow.Controls.Add(bc);
                    }
                    return;
                }

                var q = dcdc.Books.Where(x => x.Category.Name.Equals(cbCategories.Text));

                if (q.Count() == 0)
                {
                    lblNot.Visible = true;

                    return;
                }
                lblNot.Visible = false;
                foreach (var item in q)
                {
                    Book_Control bc = new Book_Control();
                    bc.Margin = new Padding(15);
                    bc.lblname.Text = item.Title;
                    bc.lblcategory.Text = item.Category.Name;
                    bc.id.Text = item.Id.ToString();
                    bc.rating.Value = item.Rating;
                    bc.lblrating.Text = "( " + item.Rating.ToString() + " )";
                    bc.lbllike.Text = item.Likes.ToString() + " likes";
                    DataStorage.LoadImageBook(bc.picImage, item);

                    flow.Controls.Add(bc);
                }
                return;
            }
            if (cbCategories.Text == "All")
            {
                var r = dcdc.Books.Where(x => x.Title.Contains(tbSearch.Text));

                if (r.Count() == 0)
                {
                    lblNot.Visible = true;

                    return;
                }
                lblNot.Visible = false;
                foreach (var item in r)
                {
                    Book_Control bc = new Book_Control();
                    bc.Margin = new Padding(15);
                    bc.lblname.Text = item.Title;
                    bc.lblcategory.Text = item.Category.Name;
                    bc.id.Text = item.Id.ToString();
                    bc.rating.Value = item.Rating;
                    bc.lblrating.Text = "( " + item.Rating.ToString() + " )";
                    bc.lbllike.Text = item.Likes.ToString() + " likes";
                    DataStorage.LoadImageBook(bc.picImage, item);

                    flow.Controls.Add(bc);
                }
                return;
            }

            var query = dcdc.Books.Where(x => x.Category.Name.Equals(cbCategories.Text) && x.Title.Contains(tbSearch.Text));

            if (query.Count() == 0)
            {
                lblNot.Visible = true;

                return;
            }
            lblNot.Visible= false;
            foreach (var item in query)
            {
                Book_Control bc = new Book_Control();
                bc.Margin = new Padding(15);
                bc.lblname.Text = item.Title;
                bc.lblcategory.Text = item.Category.Name;
                bc.id.Text = item.Id.ToString();
                bc.rating.Value = item.Rating;
                bc.lblrating.Text = "( " + item.Rating.ToString() + " )";
                bc.lbllike.Text = item.Likes.ToString() + " likes";
                DataStorage.LoadImageBook(bc.picImage, item);

                flow.Controls.Add(bc);
            }
        }

        private void loadcbcategoties()
        {
            cbCategories.Items.Clear();
            var roles = dcdc.Categories;
            cbCategories.DataSource = dcdc.Categories;

            cbCategories.ValueMember = "Id";
            cbCategories.DisplayMember = "Name";
            List<string> a = new List<string>();
            a.Add("All");
            foreach (var b in roles)
            {
                a.Add(b.Name);
            }
            cbCategories.DataSource = a;
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

        private void pBook_Click(object sender, EventArgs e)
        {
            timerLeftPanel.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelBooks.FillColor = Color.FromArgb(55, 130, 159, 244);

            timerLeftPanel.Start();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            loadFlow();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadFlow();
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
            pAccount.Visible=true;
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
            Account_Dialog ad = new Account_Dialog(DataStorage.id);
            ad.ShowDialog();


        }

        private void logoInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible = true;
        }

        private void labelInfo_MouseHover(object sender, EventArgs e)
        {
            pInfo.Visible=true;
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

        private void pInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Info_Dialog info = new Info_Dialog();
            info.ShowDialog();
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

        private void pInfo_Click(object sender, EventArgs e)
        {
            Info_Dialog i = new Info_Dialog();  
            i.ShowDialog();

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
            Manage_Item_Form m = new Manage_Item_Form();
            m.Show();
            this.Hide();
        }

        private void pMacc_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void panelManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void labelManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void logoManageAccount_MouseHover(object sender, EventArgs e)
        {
            pMacc.Visible = true;
        }

        private void pMacc_MouseLeave(object sender, EventArgs e)
        {
            pMacc.Visible = false;
        }

        private void pMacc_Click(object sender, EventArgs e)
        {
            Manage_Account_Form m = new Manage_Account_Form();
            m.Show();
            this.Hide();
        }

        private void pTimer_MouseHover(object sender, EventArgs e)
        {
            pTimer.Visible = true;
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

        private void pTimer_MouseLeave(object sender, EventArgs e)
        {
            pTimer.Visible = false;
        }

        private void pTimer_Click(object sender, EventArgs e)
        {
            Timer_Borrowed_Book_Form b = new Timer_Borrowed_Book_Form();
            b.Show();
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

        private void pBook_MouseHover(object sender, EventArgs e)
        {
            pBook.Visible = true;
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

        private void pBook_MouseLeave(object sender, EventArgs e)
        {
            pBook.Visible = false;
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
    }
}
