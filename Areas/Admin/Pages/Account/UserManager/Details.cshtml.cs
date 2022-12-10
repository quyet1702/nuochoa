using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ButterflyCarair.Models;

namespace ButterflyCarair.Pages_UserManager
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly but73756_butterflycarairContext _context;
        private readonly UserManager<User> _userManager;

        public DetailsModel(but73756_butterflycarairContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public new User User { get; set; } = default!; 
        public UserInfo userInfo {get;set;} = new UserInfo();

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
                userInfo.UserName = user.UserName;
                userInfo.FullName = user.FullName;
                userInfo.Email = user.Email;
                userInfo.PhoneNumber = user.PhoneNumber;
                userInfo.Roles = string.Join(", ",(await _userManager.GetRolesAsync(user)));
            }
            return Page();
        }

        public class UserInfo {
            public string? UserName {get;set;}
            public string? FullName {get;set;}
            public string? Email {get;set;}
            public string? PhoneNumber {get;set;}
            public string? Roles {get;set;}
        }
    }
}
