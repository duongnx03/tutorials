using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WDA1_CF.Models;

namespace WDA1_CF.Areas.Admin.Views.Admin
{
    public class CreateModel : PageModel
    {
        private readonly WDA1_CF.Models.DatabaseContext _context;

        public CreateModel(WDA1_CF.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccountTb AccountTb { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Accounts == null || AccountTb == null)
            {
                return Page();
            }

            _context.Accounts.Add(AccountTb);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
