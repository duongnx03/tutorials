using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Homework2.Models;

namespace Homework2.Views
{
    public class ShowModel : PageModel
    {
        private readonly Homework2.Models.BankDbContext _context;

        public ShowModel(Homework2.Models.BankDbContext context)
        {
            _context = context;
        }

        public IList<TbPerson> TbPerson { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TbPeople != null)
            {
                TbPerson = await _context.TbPeople.ToListAsync();
            }
        }
    }
}
