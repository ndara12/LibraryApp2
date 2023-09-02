using System;
using System.Linq;

namespace LibraryApp
{
    public class Library
    {
        private readonly LibraryDbContext _context;

        public Library(LibraryDbContext context)
        {
            _context = context;
        }

        // Add a book to the database
        public void AddBook(string bookName, string author, string type)
        {
            var book = new Book
            {
                BookName = bookName,
                Author = author,
                Type = type,
                Status = "Available"
            };

            _context.BookTable.Add(book);
            _context.SaveChanges();
        }

        // Remove a book from the database by book ID
        public void RemoveBook(int bookId)
        {
            var book = _context.BookTable.Find(bookId);

            if (book != null)
            {

                var removedBook = new RemovedBook
                {

                    BookName = book.BookName,
                    Author = book.Author,
                    Type = book.Type,
                    Status = book.Status
                };


                _context.RemovedBooks.Add(removedBook);
                if (book.Status == "Borrowed")
                {

                    var patrons = _context.Patron.ToList();
                    foreach (var patron in patrons)
                    {
                        if (!string.IsNullOrEmpty(patron.Borrowed))
                        {
                            var borrowedBooks = patron.Borrowed.Split(',');
                            var updatedBorrowedBooks = new List<string>();

                            foreach (var borrowedBook in borrowedBooks)
                            {

                                if (!string.Equals(borrowedBook.Trim(), book.BookName, StringComparison.OrdinalIgnoreCase))
                                {
                                    updatedBorrowedBooks.Add(borrowedBook);
                                }
                            }


                            patron.Borrowed = string.Join(",", updatedBorrowedBooks);
                        }
                    }


                    _context.BookTable.Remove(book);


                    _context.SaveChanges();
                }
                else
                {

                    _context.BookTable.Remove(book);


                    _context.SaveChanges();
                }

            }
        }


        // Add a patron to the database
        public void AddPatron(string name, string address, string phone)
        {
            var patron = new Patron
            {
                Name = name,
                Adress = address,
                Phone = phone,
                Borrowed = null
            };

            _context.Patron.Add(patron);
            _context.SaveChanges();
        }

        // Remove a patron from the database by customer ID
        public void RemovePatron(int customerId)
        {
            var patron = _context.Patron.Find(customerId);

            if (patron != null)
            {
                if (!string.IsNullOrEmpty(patron.Borrowed))
                {
                    var borrowedBooks = patron.Borrowed.Split(',');

                    foreach (var borrowedBookName in borrowedBooks)
                    {
                        var book = _context.BookTable.FirstOrDefault(b => b.BookName == borrowedBookName.Trim());

                        if (book != null)
                        {

                            book.Status = "Available";

                        }
                    }
                }

                _context.Patron.Remove(patron);

                _context.SaveChanges();
            }
        }


        // borrow a book
        public void CheckoutBook(int customerId, int bookId)
        {
            var book = _context.BookTable.Find(bookId);
            var patron = _context.Patron.Find(customerId);

            if (book != null && patron != null && book.Status == "Available")
            {
                if (string.IsNullOrEmpty(patron.Borrowed))
                {
                    patron.Borrowed = book.BookName;
                }
                else
                {
                    patron.Borrowed = book.BookName + "," + patron.Borrowed;
                }

                book.Status = "Borrowed";

                _context.SaveChanges();
            }
     
        }

        //return book

        public void ReturnBook(int customerId, int bookId)
        {
            var patron = _context.Patron.Find(customerId);
            var book = _context.BookTable.Find(bookId);

            if (patron != null && book != null)
            {

                book.Status = "Available";

                if (!string.IsNullOrEmpty(patron.Borrowed))
                {
                    var borrowedBooks = patron.Borrowed.Split(',').Select(b => b.Trim()).ToList();

                    borrowedBooks.Remove(book.BookName);

                    patron.Borrowed = string.Join(",", borrowedBooks);
                }

                // Save changes to the database
                _context.SaveChanges();
            }
        }


        // List all checked-out books
        public List<Book> ListCheckedOutBooks()
        {
            return _context.BookTable.Where(book => book.Status == "Borrowed").ToList();
        }

        public List<Book> ListAvailableBooks()
        {
            return _context.BookTable.Where(book => book.Status == "Available").ToList();
        }
        public List<Patron> GetAllPatrons()
        {
            return _context.Patron.ToList();
        }

    }
}
