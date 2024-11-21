using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie03.Data;
using RazorPagesMovie03.Models;

namespace RazorPagesMovie03.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie03.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie03.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
