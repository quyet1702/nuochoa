using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ButterflyCarair.Pages;

public class NewsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public NewsModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public List<New> news {get;set;}
    public void OnGet()
    {
        news = _context.News.ToList();
      
    }
}
