using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Esemka_School_Library
{
    public partial class Day_Control : UserControl
    {
        DataClassesDataContext dcdc = new DataClassesDataContext();
        public int id;
        public Day_Control()
        {
            InitializeComponent();
        }

        private void Day_Control_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            var q = dcdc.Books.Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (btnDay.Text == "3 Day")
            {
                borrowBook(1, 3);

            }
            else if (btnDay.Text == "7 Day")
            {
                borrowBook(2, 7);
            }
            else if (btnDay.Text == "14 Day")
            {
                borrowBook(3, 14);
            }
            else if (btnDay.Text == "30 Day")
            {
                borrowBook(4, 30);
            }
        }

        private void borrowBook(int day, int days)
        {
            Borrow_Book b = new Borrow_Book();
            b.Id = 1;
            b.member_Id = DataStorage.id;
            b.book_Id = id;
            b.borrow_category_Id = day;
            b.borrow_date = DateTime.Now;
            b.book_return_date = DateTime.Now.AddDays(days);
            b.is_return = "false";
            dcdc.Borrow_Books.InsertOnSubmit(b);
            
            dcdc.SubmitChanges();

            Book q = dcdc.Books.Where(x => x.Id == id).FirstOrDefault();
            int c = Convert.ToInt32(q.Stock) - 1;
            q.Stock = c;
            dcdc.SubmitChanges();

            MessageBox.Show("Borrowing Books is Successful. Please Pick up The Book at The Library", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ParentForm.Close();

        }

    }
}
