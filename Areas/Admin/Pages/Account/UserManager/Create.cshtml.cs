#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;
using ButterflyCarair.Models;

namespace ButterflyCarair.Pages_UserManager
{
    // [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserStore<User> _userStore;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<CreateModel> logger,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _logger = logger;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [Required]
            [Display(Name = "Tên tài khoản")]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            // [DataType(DataType.Password)]
            // [Display(Name = "Confirm password")]
            // [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            // public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "Họ và Tên")]
            public string FullName { get; set; }

            [Required]
            [Phone]
            [Display(Name = "Số Điện Thoại")]
            public string PhoneNumber { get; set; }

            [Required]
            public string AccountType { get; set; }
            
        }
        [BindProperty]
   		public List<SelectListItem> accountTypes { get; } = new List<SelectListItem>
       	 	{
           	 	new SelectListItem { Value = "Admin", Text = "Admin" },
            	new SelectListItem { Value = "Khách hàng", Text = "Khách hàng" }
        	};


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = Activator.CreateInstance<User>();
                user.Email = Input.Email;
                user.PhoneNumber = Input.PhoneNumber;
                user.FullName = Input.FullName;
                await _userStore.SetUserNameAsync(user, Input.UserName, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);
                if(result.Succeeded){
                    var IsRoleExist = await _roleManager.RoleExistsAsync(Input.AccountType);
                    if(!IsRoleExist){
                        var newRole = new IdentityRole (Input.AccountType);
                        await _roleManager.CreateAsync (newRole);
                    }
                    var getUser = await _userManager.FindByNameAsync(Input.UserName);
                    var roleResult = await _userManager.AddToRoleAsync(getUser, Input.AccountType);

                    return RedirectToPage("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }
    }
}
