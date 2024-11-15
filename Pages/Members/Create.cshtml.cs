using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tusa_Alexandra_Teodora_Lab2.Data;
using Tusa_Alexandra_Teodora_Lab2.Models;

namespace Tusa_Alexandra_Teodora_Lab2.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Tusa_Alexandra_Teodora_Lab2.Data.Tusa_Alexandra_Teodora_Lab2Context _context;

        public CreateModel(Tusa_Alexandra_Teodora_Lab2.Data.Tusa_Alexandra_Teodora_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Member Member { get; set; } = new Member();

        public IActionResult OnGet()
        {
            return Page();
        }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
