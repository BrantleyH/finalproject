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
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.CardDbContext _context;

        public DetailsModel(FinalProject.Models.CardDbContext context)
        {
            _context = context;
        }

      public BaseballCard BaseballCard { get; set; } = default!; 
      [BindProperty]
      public int OwnerIDToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BaseballCards == null)
            {
                return NotFound();
            }

            var baseballcard = await _context.BaseballCards.Include(m => m.Owners).FirstOrDefaultAsync(m => m.BaseballCardID == id);
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
        public IActionResult OnPostDeleteReview(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Find the review in the database
            var Review = _context.Owners.FirstOrDefault(r => r.OwnerID == OwnerIDToDelete);
            
            if (Review != null)
            {
                _context.Remove(Owner); // Delete the review
                _context.SaveChanges();
            }

            BaseballCard = _context.BaseballCards.Include(m => m.Owners).First(m => m.BaseballCardID == id);

            return Page();
        }
    }
}
