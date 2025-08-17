using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Esemka_School_Library.DataStorage;

namespace Esemka_School_Library
{
    public partial class Detail_Book_Form : Form
    {
        bool menu;
        public static bool likes;
        int stock;
        Form m;
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public Detail_Book_Form(bool like, Form m)
        {
            InitializeComponent();
            likes = like;
            this.m = m;
        }

        private void Detail_Book_Form_Load(object sender, EventArgs e)
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
            loadData();

            
            loadFlow();

            loadBtnLikeSave();
        }

        private void loadBtnLikeSave()
        {
            if (likes)
            {
                btnlike.Image = Properties.Resources.favorite_fill;
                btnlike.FillColor = Color.Gainsboro;
                int angka = Convert.ToInt32(lbllike.Text.ToString().Replace(" likes", "")) + 1;
                lbllike.Text = angka.ToString() + " likes";
            }

            if (DataStorage.role)
            {
                btnBorrow.Visible = false;
            }


            if (DataStorage.role)
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Non_Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    btnSave.Image = Properties.Resources.bookmark;
                }
                else
                {
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
            }
            else
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    btnSave.Image = Properties.Resources.bookmark;
                }
                else
                {
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
            }
        }
        private void loadData()
        {
            var q = dcdc.Books.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();

            lblname.Text = q.Title;
            lbldescription.Text = q.Synopsis;
            lblrating.Text = "( " + q.Rating.ToString() + " )";
            rating.Value = q.Rating;
            DataStorage.LoadImageBook(picImage, q);
            lbllike.Text = q.Likes.ToString() + " likes";
            lblWriter.Text = "Writer: " + q.Writer;
            lblYear.Text = "Publication Year: " + q.Publication_Year.ToString();
            lblstock.Text = "Stock Book: " + q.Stock.ToString();
            stock = Convert.ToInt32(q.Stock);
            
        }
        
        private void loadFlow()
        {
            flowBook.Controls.Clear();

            var q = dcdc.Books.Where(x => x.Categories_Id == dcdc.Books.Where(y => y.Id.Equals(id.Text)).Select(z => z.Categories_Id).FirstOrDefault() && x.Id != Convert.ToInt32(id.Text));

            if (q.Count() == 0)
            {
                lblserupa.Visible = true;
                return;
            }

            lblserupa.Visible = false;  
            foreach (var y in q)
            {
                Book_Control_Main bc = new Book_Control_Main();
                bc.lblname.Text = y.Title;
                bc.id.Text = y.Id.ToString();
                bc.Margin = new Padding(10);
                DataStorage.LoadImageBook(bc.picImage, y);
                bc.lblcategory.Text = y.Category.Name;
                flowBook.Controls.Add(bc);

            }
        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            if (likes)
            {
                btnlike.Image = Properties.Resources.favorite;
                btnlike.FillColor = Color.FromArgb(250, 238, 238, 238);
                int angka = Convert.ToInt32(lbllike.Text.ToString().Replace(" likes", "")) - 1;
                lbllike.Text = angka.ToString() + " likes";
                likes = false;
            }
            else
            {
                btnlike.Image = Properties.Resources.favorite_fill;
                btnlike.FillColor = Color.Gainsboro;
                int angka = Convert.ToInt32(lbllike.Text.ToString().Replace(" likes", "")) + 1;
                lbllike.Text = angka.ToString() + " likes";
                likes = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelBooks.FillColor = Color.FromArgb(55, 130, 159, 244);

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
                
                Form newPreviousForm = (Form)Activator.CreateInstance(previousForm.GetType());

                newPreviousForm.Show(); 
                this.Close();
            }
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

        private void pLogout_MouseClick(object sender, MouseEventArgs e)
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
            Account_Dialog ad = new Account_Dialog(DataStorage.id);
            ad.ShowDialog();
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

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            var q = dcdc.Borrow_Books.Where(x => x.member_Id == DataStorage.id);
            var w = dcdc.Borrow_Books.Where(x => x.book_Id == Convert.ToInt32(id.Text) && x.member_Id == DataStorage.id).FirstOrDefault();
            if (stock == 0)
            {
                MessageBox.Show("Book stock is not available");
                return;
            }
            else if (q.Count() >= 2)
            {
                MessageBox.Show("You Can Only Borrow Two Books");
                return;
            }
            else if (w != null)
            {
                MessageBox.Show("You Have Borrowed This Book");
                return;
            }
            

            Borrow_Day_Dialog b = new Borrow_Day_Dialog(Convert.ToInt32(id.Text));
            b.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataStorage.role)
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Non_Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    Saved_Book s = new Saved_Book();
                    s.Book_Id = Convert.ToInt32(id.Text);
                    s.Non_Member_Id = DataStorage.id;
                    s.id = 1;
                    dcdc.Saved_Books.InsertOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
                else
                {
                    Saved_Book s = q;
                    dcdc.Saved_Books.DeleteOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark;
                }
            }
            else
            {
                var q = dcdc.Saved_Books.Where(x => x.Book_Id.Equals(id.Text) && x.Member_Id.Equals(DataStorage.id)).FirstOrDefault();

                if (q == null)
                {
                    Saved_Book s = new Saved_Book();
                    s.Book_Id = Convert.ToInt32(id.Text);
                    s.Member_Id = DataStorage.id;
                    s.id = 1;
                    dcdc.Saved_Books.InsertOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark_fill;
                }
                else
                {
                    Saved_Book s = q;
                    dcdc.Saved_Books.DeleteOnSubmit(s);
                    dcdc.SubmitChanges();
                    btnSave.Image = Properties.Resources.bookmark;
                    
                }

            }
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

        private void pMacc_Click(object sender, EventArgs e)
        {
            Manage_Account_Form m = new Manage_Account_Form();
            m.Show();
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
            Saved_Book_Form m = new Saved_Book_Form();
            m.Show();
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
            timerLeftPanel.Start();
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
