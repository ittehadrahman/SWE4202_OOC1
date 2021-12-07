using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment_System
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bookhistoryshowbutton_Click(object sender, EventArgs e)
        {
            foreach(Book dummy in books)
            {
                if(dummy.BookID == Convert.ToInt32(BookhistorybookIDtextbox.Text))
                {
                    IDlabel.Text = Convert.ToString(dummy.BookID);
                    Namelabel.Text = dummy.Bookname;
                    Authorlabel.Text = dummy.Author;
                    Publisherlabel.Text = dummy.Publisher;
                    Quantitylabel.Text = Convert.ToString(dummy.Quantity);
                }
                else
                {
                    MessageBox.Show("ID not found");
                }
            }
        }

        private void Addbookbutton_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(BookIDtextbox.Text);
            string bookname = Booknametextbox.Text;
            string author = Authortextbox.Text;
            string publisher = Publishertextbox.Text;
            int quantity = Convert.ToInt32(Quantitytextbox.Text);

            Book dummy_book = new Book();
            dummy_book.BookID = bookid;
            dummy_book.Bookname = bookname;
            dummy_book.Author = author;
            dummy_book.Publisher = publisher;
            dummy_book.Quantity = quantity;

            books.Add(dummy_book);

            MessageBox.Show("Book has been added successfully!");
        }

        private void Adduserbutton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDtextbox.Text);
            string username = Nametextbox.Text;
            string address = Addresstextbox.Text;
            
            User dummy_user = new User();
            dummy_user.UserID = userID;
            dummy_user.Username = username;
            dummy_user.Address = address;

            users.Add(dummy_user);

            MessageBox.Show("User has been added succesfully!!");
        }

        private void Userhistoryshowbutton_Click(object sender, EventArgs e)
        {
            Userhistorylistbox.Items.Clear();
            foreach (User dummy in users)
            {
                if (dummy.UserID == Convert.ToInt32(UserhistoryuserIDtextbox.Text))
                {
                    foreach(Book book in dummy.bookList)
                    {
                        Userhistorylistbox.Items.Add(book.get());
                    }
                }
            }
        }

        private void Borrowbookbutton_Click(object sender, EventArgs e)
        {
            Book dummyBook = new Book();
            foreach(Book book in books)
            {
                if (Convert.ToString(book.BookID) == BorrowbookIDtextbox.Text)
                {
                    dummyBook = book;
                }
            }
            if (dummyBook.Quantity == 0)
            {
                MessageBox.Show("Book out of stock");
                return;
            }
            else
            {
                dummyBook.borrow();
            }
            foreach(User user in users)
            {
                if (user.getInfo() == BorrowuserIDtextbox.Text)
                {
                    user.borrowBook(dummyBook);
                }
            }
            MessageBox.Show("Book Borrowed");


        }

        private void BorrowuserIDtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BorrowbookIDtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
