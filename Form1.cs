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
        private void LoadPatronNames()
        {
            comboBox2.Items.Clear();

            var patrons = _library.GetAllPatrons();

            foreach (var patron in patrons)
            {
                comboBox2.Items.Add($"{patron.CustomerId}: {patron.Name}");
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







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {       

        }

    }
}
