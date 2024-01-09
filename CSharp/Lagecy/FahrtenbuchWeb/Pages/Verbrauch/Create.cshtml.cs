using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FahrtenbuchWeb.Data;
using FahrtenbuchWeb.Models;

namespace FahrtenbuchWeb.Pages.Verbrauch
{
    public class CreateModel : PageModel
    {
        private readonly FahrtenbuchWeb.Data.ApplicationDbContext _context;

        public CreateModel(FahrtenbuchWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VerbrauchModel VerbrauchModel { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.verbrauchModels.Add(VerbrauchModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
