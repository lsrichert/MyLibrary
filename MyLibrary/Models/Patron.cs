using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Patron
    {
        [Key]
        public int PatronId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name="Checked Out Books")]
        public int BookId { get; set; }

        public Book Book { get; set; }

    }
}
