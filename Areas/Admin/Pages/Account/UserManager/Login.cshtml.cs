#nullable disable
using System.ComponentModel.DataAnnotations;
using ButterflyCarair.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace ButterflyCarair.Pages.Account;
public class LoginModel:PageModel {
    private readonly ILogger<LoginModel> _logger;
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public LoginModel(ILogger<LoginModel> logger, SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public void OnGet()
    {

    }
    [BindProperty]
    public InputLogin Input {get;set;}
    public async Task<IActionResult> OnPostAsync(){
        if(ModelState.IsValid){
            var user = await _userManager.FindByNameAsync(Input.UserName);
            if(user is not null){
                await _signInManager.SignInAsync(user,Input.IsRemember);
                return LocalRedirect("~/Admin/Products/");
            }
            else{
                ModelState.AddModelError(string.Empty, "Sai tài khoản hoặc mật khẩu.");
                return Page();
            }
        }
        return Page();
    }

    public class InputLogin {
        [Required]
        public string UserName {get; set;}
        [Required]
        public string Password {get; set;}
        public bool IsRemember {get;set;} =false;
    }
}