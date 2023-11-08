using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FahrtenbuchWeb_New.Data;
using FahrtenbuchWeb_New.Models;

namespace FahrtenbuchWeb_New.Pages.Verbrauch
{
    public class CreateModel : PageModel
    {
        private readonly FahrtenbuchWeb_New.Data.ApplicationDbContext _context;

        public CreateModel(FahrtenbuchWeb_New.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FahrtenbuchWeb_New.Models.Verbrauch Verbrauch { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Verbrauches.Add(Verbrauch);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
