using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace finalproject.Pages.BaseballCards
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.CardDbContext _context;

        public IndexModel(FinalProject.Models.CardDbContext context)
        {
            _context = context;
        }

        public IList<BaseballCard> BaseballCard { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = default!;

        public async Task OnGetAsync()
            {
                var query =_context.BaseballCards.Select(p => p);
                switch (CurrentSort)
                {
                    case "first_asc":
                    query = query.OrderBy(p => p.Name);
                    break;
                    case "first_desc":
                    query = query.OrderByDescending(p => p.Name);
                    break;
                }
                BaseballCard = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
    }
}
