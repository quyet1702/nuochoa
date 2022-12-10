using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ButterflyCarair.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public IndexModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public List<Product> products {get;set;} = new List<Product>();
    public List<Product> productsType1 {get;set;} = new List<Product>();
    public List<Product> productsType2 {get;set;} = new List<Product>();
    public List<Product> productsType3 {get;set;} = new List<Product>();

    public void OnGet()
    {
        products = _context.Products.ToList();
        productsType1 = _context.Products.Where(p=>p.Promotion==true).OrderBy(p=>p.ProductLocation).ToList();
        productsType2 = _context.Products.Where(p=>p.ProductType=="1").OrderBy(p=>p.ProductLocation).ToList();
        productsType3 = _context.Products.Where(p=>p.ProductType=="2").OrderBy(p=>p.ProductLocation).ToList();
    }
}
