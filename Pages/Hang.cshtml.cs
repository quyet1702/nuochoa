using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ButterflyCarair.Pages;

public class HangModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public HangModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public List<Product> productsType2 {get;set;} = new List<Product>();
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
        productsType2 = _context.Products.Where(p=>p.ProductType=="3").ToList();
        if(brand!=null && productsType2.Count>0){
            productsType2 = productsType2.Where(p=>p.Trademark==brand).ToList();
        }
        if(maxPrice!=null && minPrice!=null && productsType2.Count>0){
            productsType2 = productsType2.Where(p=>(p.Price>=minPrice && p.Price<maxPrice)).ToList();
        }
    }
}
