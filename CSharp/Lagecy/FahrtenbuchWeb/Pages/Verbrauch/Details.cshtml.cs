using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FahrtenbuchWeb.Data;
using FahrtenbuchWeb.Models;

namespace FahrtenbuchWeb.Pages.Verbrauch
{
    public class DetailsModel : PageModel
    {
        private readonly FahrtenbuchWeb.Data.ApplicationDbContext _context;

        public DetailsModel(FahrtenbuchWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public VerbrauchModel VerbrauchModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.verbrauchModels == null)
            {
                return NotFound();
            }

            var verbrauchmodel = await _context.verbrauchModels.FirstOrDefaultAsync(m => m.ID == id);
            if (verbrauchmodel == null)
            {
                return NotFound();
            }
            else 
            {
                VerbrauchModel = verbrauchmodel;
            }
            return Page();
        }
    }
}
