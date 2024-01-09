using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FahrtenbuchWeb_New.Data;
using FahrtenbuchWeb_New.Models;

namespace FahrtenbuchWeb_New.Pages.Verbrauch
{
    public class DeleteModel : PageModel
    {
        private readonly FahrtenbuchWeb_New.Data.ApplicationDbContext _context;

        public DeleteModel(FahrtenbuchWeb_New.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public FahrtenbuchWeb_New.Models.Verbrauch Verbrauch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Verbrauches == null)
            {
                return NotFound();
            }

            var verbrauch = await _context.Verbrauches.FirstOrDefaultAsync(m => m.Id == id);

            if (verbrauch == null)
            {
                return NotFound();
            }
            else 
            {
                Verbrauch = verbrauch;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Verbrauches == null)
            {
                return NotFound();
            }
            var verbrauch = await _context.Verbrauches.FindAsync(id);

            if (verbrauch != null)
            {
                Verbrauch = verbrauch;
                _context.Verbrauches.Remove(Verbrauch);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
