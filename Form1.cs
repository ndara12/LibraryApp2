using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private readonly Library _library;

        public Form1()
        {
            InitializeComponent();
            _library = new Library(new LibraryDbContext());
            LoadAvailableBooks();
            LoadPatronNames();
            LoadBorrowedBooks();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            var checkedOutBooks = _library.ListCheckedOutBooks();

            listBox1.Items.Clear();

            foreach (var book in checkedOutBooks)
            {
                listBox1.Items.Add($"{book.BookName} ({book.Author})");

            }

            LoadAvailableBooks();
            LoadPatronNames();
            LoadBorrowedBooks();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a book and a patron.");
                return;
            }

       
            string selectedBook = comboBox1.SelectedItem.ToString();
            string selectedPatron = comboBox2.SelectedItem.ToString();

            int bookId;
            int customerId;

            
            if (int.TryParse(selectedBook.Split('-')[0].Trim(), out bookId))
            {
               
                if (int.TryParse(selectedPatron.Split(':')[0].Trim(), out customerId))
                {
                 
                    _library.CheckoutBook(customerId, bookId);

                 
                    MessageBox.Show($"Book rented to Customer {customerId}");


                }
                else
                {
                    MessageBox.Show("Invalid patron selection. Please select a valid patron.");
                }
            }
            else
            {
                MessageBox.Show("Invalid book selection. Please select a valid book.");
            }
            LoadAvailableBooks();
            LoadPatronNames();
            LoadBorrowedBooks();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text.Trim();
            string address = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            
            _library.AddPatron(name, address, phone);

           
            MessageBox.Show("Patron added successfully.");

            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            LoadAvailableBooks();
            LoadPatronNames();
            LoadBorrowedBooks();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a patron to remove.");
                return;
            }

           
            string selectedPatron = comboBox3.SelectedItem.ToString();
            int customerId;

            if (int.TryParse(selectedPatron.Split(':')[0].Trim(), out customerId))
            {
                _library.RemovePatron(customerId);

                
                MessageBox.Show($"Patron with Customer ID {customerId} removed.");
            }
            else
            {
                MessageBox.Show("Invalid patron selection. Please select a valid patron.");
            }
            LoadAvailableBooks();
            LoadPatronNames();
            LoadPatronNames();
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
            if (comboBox5.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer and a book.");
                return;
            }

            string selectedCustomer = comboBox5.SelectedItem.ToString();
            string selectedBook = comboBox4.SelectedItem.ToString();

            int customerId;
            int bookId;

            if (int.TryParse(selectedCustomer.Split(':')[0].Trim(), out customerId))
            {
                if (int.TryParse(selectedBook.Split('-')[0].Trim(), out bookId))
                {
                    bool isBookReturned = _library.ReturnBook(customerId, bookId);

                    if (isBookReturned)
                    {
                        MessageBox.Show($"Book returned by Customer {customerId}");
                    }
                    else
                    {
                        MessageBox.Show($"Book was not found in the customer's borrowed list.");
                    }

                 
                    
                }
                else
                {
                    MessageBox.Show("Invalid book selection. Please select a valid book.");
                }
            }
            else
            {
                MessageBox.Show("Invalid customer selection. Please select a valid customer.");
            }
            LoadAvailableBooks();
            LoadPatronNames();
            LoadPatronNames();
        }

        private void LoadAvailableBooks()
        {
            comboBox1.Items.Clear();

            var availableBooks = _library.ListAvailableBooks();

            foreach (var book in availableBooks)
            {
                
                comboBox1.Items.Add($"{book.BookId} - {book.BookName} ({book.Author}), Type: {book.Type}, Status: {book.Status}");
                comboBox4.Items.Add($"{book.BookId} - {book.BookName} ({book.Author}), Type: {book.Type}, Status: {book.Status}");

            }
        }
        private void LoadBorrowedBooks()
        {
            comboBox4.Items.Clear();

            var borrowedBooks = _library.ListCheckedOutBooks();

            foreach (var book in borrowedBooks)
            {
               
                comboBox4.Items.Add($"{book.BookId} - {book.BookName}");
            }
        }

        private void LoadPatronNames()
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            var patrons = _library.GetAllPatrons();

            foreach (var patron in patrons)
            {
                comboBox2.Items.Add($"{patron.CustomerId}: {patron.Name}");
                comboBox3.Items.Add($"{patron.CustomerId}: {patron.Name}");
                comboBox5.Items.Add($"{patron.CustomerId}: {patron.Name}");
            }
        }
     
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }



    }
}
