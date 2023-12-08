using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace finalproject.Pages.BaseballCards
{
    public class AddOwnerModel : PageModel
    {
        private readonly ILogger<AddOwnerModel> _logger;
        private readonly CardDbContext _context;
        [BindProperty]
        public Owner Owner {get; set;} = default!;
        public SelectList BaseballCardsDropDown {get; set;} = default!;

        public AddOwnerModel(CardDbContext context, ILogger<AddOwnerModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            BaseballCardsDropDown = new SelectList(_context.BaseballCards.ToList(), "BaseballCardID", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Owners.Add(Owner);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
