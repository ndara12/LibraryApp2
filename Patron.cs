using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Numerics;

namespace LibraryApp
{
    public class Patron
    {
        [Key]
        public int CustomerId { get; set; }
        public string? Name { get; set; }  // ? means it can be nullable        
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Borrowed { get; set; }
    }


}

