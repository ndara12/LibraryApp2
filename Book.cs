using System.ComponentModel.DataAnnotations;

namespace LibraryApp
{
    public class Book
    // Specify the table name here
    {
        [Key]
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? Type { get; set; }
        public string Status { get; set; }

    }

}
