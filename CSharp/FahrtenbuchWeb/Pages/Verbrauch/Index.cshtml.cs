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
    public class IndexModel : PageModel
    {
        private readonly FahrtenbuchWeb.Data.ApplicationDbContext _context;

        public IndexModel(FahrtenbuchWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<VerbrauchModel> VerbrauchModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.verbrauchModels != null)
            {
                VerbrauchModel = await _context.verbrauchModels.ToListAsync();
            }
        }
    }
}
