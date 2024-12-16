using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repere.Data;
using repere.models;

namespace repere.Pages.Requests
{
    public class IndexModel : PageModel
    {
        private readonly repere.Data.repereContext _context;

        public IndexModel(repere.Data.repereContext context)
        {
            _context = context;
        }

        public IList<Request> Request { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Request = await _context.Request.ToListAsync();
        }
    }
}
