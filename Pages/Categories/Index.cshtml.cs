using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tusa_Alexandra_Teodora_Lab2.Data;
using Tusa_Alexandra_Teodora_Lab2.Migrations;
using Tusa_Alexandra_Teodora_Lab2.Models.ViewModels;

namespace Tusa_Alexandra_Teodora_Lab2.Pages.Categories
{

    public class IndexModel : PageModel
    {
        private readonly Tusa_Alexandra_Teodora_Lab2.Data.Tusa_Alexandra_Teodora_Lab2Context _context;

        public IndexModel(Tusa_Alexandra_Teodora_Lab2.Data.Tusa_Alexandra_Teodora_Lab2Context context)
        {
            _context = context;
        }

        public Models.ViewModels.CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            CategoryData = new Models.ViewModels.CategoryIndexData();
            CategoryData.Categories = await _context.Category.ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                var category = await _context.Category
                    .Include(c => c.BookCategories)
                        .ThenInclude(bc => bc.Book)
                    .Where(c => c.ID == CategoryID)
                    .SingleOrDefaultAsync();

                CategoryData.Books = category.BookCategories.Select(bc => bc.Book);
            }
        }
    }
}
