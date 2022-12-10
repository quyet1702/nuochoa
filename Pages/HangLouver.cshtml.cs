using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ButterflyCarair.Pages;

public class HangLouverModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public HangLouverModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public List<Product> products {get;set;} = new List<Product>();
    [BindProperty(SupportsGet = true)]
    public string? brand { get; set; }
    [BindProperty(SupportsGet = true)]
    public int? minPrice { get; set; }
    [BindProperty(SupportsGet = true)]
    public int? maxPrice { get; set; }
    public List<SelectListItem> brands { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "Thương hiệu (Tất cả)" },
            new SelectListItem { Value = "Areon", Text = "Areon" },
            new SelectListItem { Value = "De Project", Text = "De Project" },
            new SelectListItem { Value = "Etonner", Text = "Etonner" }
    };
    public void OnGet()
    {
        products = _context.Products.Where(p=>p.ProductType=="1").ToList();
        if(brand!=null && products.Count>0){
            products = products.Where(p=>p.Trademark==brand).ToList();
        }
        if(maxPrice!=null && minPrice!=null && products.Count>0){
            products = products.Where(p=>(p.Price>=minPrice && p.Price<maxPrice)).ToList();
        }
    }
}
