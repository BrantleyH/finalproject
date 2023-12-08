using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Models;

namespace finalproject.Pages.BaseballCards
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject.Models.CardDbContext _context;

        public CreateModel(FinalProject.Models.CardDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BaseballCard BaseballCard { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BaseballCards == null || BaseballCard == null)
            {
                return Page();
            }

            _context.BaseballCards.Add(BaseballCard);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
