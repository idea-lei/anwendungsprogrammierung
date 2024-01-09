using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FahrtenbuchWeb.Data;
using FahrtenbuchWeb.Models;

namespace FahrtenbuchWeb.Pages.Verbrauch
{
    public class EditModel : PageModel
    {
        private readonly FahrtenbuchWeb.Data.ApplicationDbContext _context;

        public EditModel(FahrtenbuchWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VerbrauchModel VerbrauchModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.verbrauchModels == null)
            {
                return NotFound();
            }

            var verbrauchmodel =  await _context.verbrauchModels.FirstOrDefaultAsync(m => m.ID == id);
            if (verbrauchmodel == null)
            {
                return NotFound();
            }
            VerbrauchModel = verbrauchmodel;
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

            _context.Attach(VerbrauchModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerbrauchModelExists(VerbrauchModel.ID))
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

        private bool VerbrauchModelExists(int id)
        {
          return _context.verbrauchModels.Any(e => e.ID == id);
        }
    }
}
