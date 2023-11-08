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
    public class IndexModel : PageModel
    {
        private readonly FahrtenbuchWeb_New.Data.ApplicationDbContext _context;

        public IndexModel(FahrtenbuchWeb_New.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<FahrtenbuchWeb_New.Models.Verbrauch> Verbrauch { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Verbrauches != null)
            {
                Verbrauch = await _context.Verbrauches.ToListAsync();
            }
        }
    }
}
