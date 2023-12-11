using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WDA1_CF.Models;

namespace WDA1_CF.Areas.Admin.Views.Admin
{
    public class IndexModel : PageModel
    {
        private readonly WDA1_CF.Models.DatabaseContext _context;

        public IndexModel(WDA1_CF.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<AccountTb> AccountTb { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Accounts != null)
            {
                AccountTb = await _context.Accounts.ToListAsync();
            }
        }
    }
}
