using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
    public class LibraryEditViewModel
    {
        public Library Library { get; set; }

        public List<SelectListItem> Books { get; set; }

        public LibraryEditViewModel(ApplicationDbContext context)
        {
            Books = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();
        }
    }
}
