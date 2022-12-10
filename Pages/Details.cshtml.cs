using System.Globalization;
using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ButterflyCarair.Pages;

public class DetailsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public DetailsModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public Product product {get;set;} = null!;
    public Scent scent {get;set;} = null!;

    public void OnGet(int? id =null)
    {
        if(id !=null){
            product = _context.Products.Include(s=>s.Scents).First(p=>p.Id==id);
        }
    }
}
