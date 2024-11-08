using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gorcea_Alexandru_Lab2.Data;
using Gorcea_Alexandru_Lab2.Models;

namespace Gorcea_Alexandru_Lab2.Pages.Members
{
    public class DeleteModel : PageModel
    {
        private readonly Gorcea_Alexandru_Lab2.Data.Gorcea_Alexandru_Lab2Context _context;

        public DeleteModel(Gorcea_Alexandru_Lab2.Data.Gorcea_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Member Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);

            if (member == null)
            {
                return NotFound();
            }
            else
            {
                Member = member;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FindAsync(id);
            if (member != null)
            {
                Member = member;
                _context.Member.Remove(Member);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
