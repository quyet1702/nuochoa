using System.Globalization;
using ButterflyCarair.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ButterflyCarair.Pages;

public class BlogDetailsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly but73756_butterflycarairContext  _context;

    public BlogDetailsModel(ILogger<IndexModel> logger, but73756_butterflycarairContext  context)
    {
        _logger = logger;
        _context = context;
    }
    public New New {get;set;} = null!;

    public void OnGet(int? id =null)
    {
        if(id !=null){
            New = _context.News.First(p=>p.Id==id);
        }
    }
}
