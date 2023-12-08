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
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Models.CardDbContext _context;

        public DeleteModel(FinalProject.Models.CardDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BaseballCard BaseballCard { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BaseballCards == null)
            {
                return NotFound();
            }

            var baseballcard = await _context.BaseballCards.FirstOrDefaultAsync(m => m.BaseballCardID == id);

            if (baseballcard == null)
            {
                return NotFound();
            }
            else 
            {
                BaseballCard = baseballcard;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.BaseballCards == null)
            {
                return NotFound();
            }
            var baseballcard = await _context.BaseballCards.FindAsync(id);

            if (baseballcard != null)
            {
                BaseballCard = baseballcard;
                _context.BaseballCards.Remove(BaseballCard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
