using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FahrtenbuchWeb_New.Data;
using FahrtenbuchWeb_New.Models;

namespace FahrtenbuchWeb_New.Pages.Verbrauch
{
    public class EditModel : PageModel
    {
        private readonly FahrtenbuchWeb_New.Data.ApplicationDbContext _context;

        public EditModel(FahrtenbuchWeb_New.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FahrtenbuchWeb_New.Models.Verbrauch Verbrauch { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Verbrauches == null)
            {
                return NotFound();
            }

            var verbrauch =  await _context.Verbrauches.FirstOrDefaultAsync(m => m.Id == id);
            if (verbrauch == null)
            {
                return NotFound();
            }
            Verbrauch = verbrauch;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Verbrauch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerbrauchExists(Verbrauch.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VerbrauchExists(int id)
        {
          return _context.Verbrauches.Any(e => e.Id == id);
        }
    }
}
