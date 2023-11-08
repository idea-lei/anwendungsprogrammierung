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
    public class DetailsModel : PageModel
    {
        private readonly FahrtenbuchWeb_New.Data.ApplicationDbContext _context;

        public DetailsModel(FahrtenbuchWeb_New.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
