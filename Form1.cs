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

        // Event handler for the button click event
        private void button1_Click(object sender, EventArgs e)
        {

            var checkedOutBooks = _library.ListCheckedOutBooks();

            listBox1.Items.Clear();

            foreach (var book in checkedOutBooks)
            {
                listBox1.Items.Add($"{book.BookName} ({book.Author})");
            }
        }
        private void LoadAvailableBooks()
        {
            comboBox1.Items.Clear();

            var availableBooks = _library.ListAvailableBooks();

            foreach (var book in availableBooks)
            {
                // Add each available book to the ComboBox
                comboBox1.Items.Add($"{book.BookId} - {book.BookName} ({book.Author}), Type: {book.Type}, Status: {book.Status}");
            }
        }
        private void LoadBorrowedBooks()
        {
            comboBox4.Items.Clear();

            var borrowedBooks = _library.ListCheckedOutBooks();

            foreach (var book in borrowedBooks)
            {
                // Add each borrowed book to the ComboBox
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
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if items are selected in both comboboxes
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a book and a patron.");
                return;
            }

            // Parse the selected items to extract bookId and customerId
            string selectedBook = comboBox1.SelectedItem.ToString();
            string selectedPatron = comboBox2.SelectedItem.ToString();

            int bookId;
            int customerId;

            // Extract BookId from selectedBook
            if (int.TryParse(selectedBook.Split('-')[0].Trim(), out bookId))
            {
                // Extract CustomerId from selectedPatron
                if (int.TryParse(selectedPatron.Split(':')[0].Trim(), out customerId))
                {
                    // Call the CheckoutBook method
                    _library.CheckoutBook(customerId, bookId);

                    // Show a message box
                    MessageBox.Show($"Book rented to Customer {customerId}");

                    // Refresh the comboboxes
                    LoadAvailableBooks();
                    LoadPatronNames();
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes
            string name = textBox1.Text.Trim();
            string address = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();

            // Check if any of the textboxes is empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Call the AddPatron method from your Library class
            _library.AddPatron(name, address, phone);

            // Show a message to indicate that the patron has been added
            MessageBox.Show("Patron added successfully.");

            // Clear the textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in comboBox3
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a patron to remove.");
                return;
            }

            // Extract customerId from selected item
            string selectedPatron = comboBox3.SelectedItem.ToString();
            int customerId;

            if (int.TryParse(selectedPatron.Split(':')[0].Trim(), out customerId))
            {
                // Call the RemovePatron method
                _library.RemovePatron(customerId);

                // Refresh the comboboxes and datagridview
                LoadAvailableBooks();
                LoadPatronNames();
                LoadPatronNames(); // You may need to load comboBox3 again if necessary

                // Show a message box
                MessageBox.Show($"Patron with Customer ID {customerId} removed.");
            }
            else
            {
                MessageBox.Show("Invalid patron selection. Please select a valid patron.");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
