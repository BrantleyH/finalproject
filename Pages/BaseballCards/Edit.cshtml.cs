using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace finalproject.Pages.BaseballCards
{
    public class EditModel : PageModel
    {
        private readonly FinalProject.Models.CardDbContext _context;

        public EditModel(FinalProject.Models.CardDbContext context)
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

            var baseballcard =  await _context.BaseballCards.FirstOrDefaultAsync(m => m.BaseballCardID == id);
            if (baseballcard == null)
            {
                return NotFound();
            }
            BaseballCard = baseballcard;
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

            _context.Attach(BaseballCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BaseballCardExists(BaseballCard.BaseballCardID))
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

        private bool BaseballCardExists(int id)
        {
          return (_context.BaseballCards?.Any(e => e.BaseballCardID == id)).GetValueOrDefault();
        }
    }
}
