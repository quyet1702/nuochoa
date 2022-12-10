using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace ButterflyCarair.Areas_Admin_Pages_Product
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ButterflyCarair.Models.but73756_butterflycarairContext _context;

        public IndexModel(ButterflyCarair.Models.but73756_butterflycarairContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string productType { get; set; }	
   		public List<SelectListItem> productTypes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Lọc sản phẩm(All)" },
            new SelectListItem { Value = "1", Text = "Kẹp cửa gió" },
            new SelectListItem { Value = "2", Text = "Đặt Taplo"  },
            new SelectListItem { Value = "3", Text = "Treo"  },
            new SelectListItem { Value = "4", Text = "Xịt"  },
        };
        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync(string? productType)
        {
            if(productType is not null){
                if(productType=="3"){
                    Product = await _context.Products.Where(p=>p.Promotion==true).ToListAsync();
                }
                else {
                    Product = await _context.Products.Where(p=>p.ProductType==productType).ToListAsync();
                }
                if(productType==""){
                    Product = await _context.Products.ToListAsync();
                }
            }
            else
                if (_context.Products != null)
                {
                    Product = await _context.Products.ToListAsync();
                }
        }
    }
}
