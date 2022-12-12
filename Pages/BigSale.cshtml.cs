using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ButterflyCarair.Pages;

public class BigSaleModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public BigSaleModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public List<Product> products {get;set;} = new List<Product>();

    public void OnGet()
    {
        products = _context.Products.Where(p=>p.Promotion==true).OrderBy(p=>p.ProductLocation).ToList();
    }
}
