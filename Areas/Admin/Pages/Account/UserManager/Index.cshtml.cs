using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ButterflyCarair.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ButterflyCarair.Pages_UserManager
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly but73756_butterflycarairContext _context;
        private readonly UserManager<User> _userManager;

        public IndexModel(but73756_butterflycarairContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public new IList<GetUserInfo> User { get;set; } = null!;

        public async Task OnGetAsync()
        {

            if (_context.Users != null)
            {
                User = new List<GetUserInfo>();
                var users = await _context.Users.ToListAsync();
                foreach(var item in users){
                    var roles = await _userManager.GetRolesAsync(item);
                    string role;
                    if(roles.Count >0){
                        role = string.Join(",",roles);
                    }
                    else
                    {
                        role ="Chưa thiết lập";
                    }
                    User.Add(new GetUserInfo(){
                        Id = item.Id,
                        UserName = item.UserName,
                        FullName = item.FullName,
                        Email = item.Email,
                        PhoneNumber = item.PhoneNumber,
                        Role = role
                    });
                }
                User = User.OrderBy(x=>x.Role).ToList();
            }

        }
    }
    public class GetUserInfo {
            public String? Id {get;set;} 
            public String? UserName {get;set;} 
            public String? FullName {get;set;} 
            public String? Email {get;set;} 
            public String? PhoneNumber {get;set;} 
            public String? Role {get;set;} 
        }
}
