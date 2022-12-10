using Microsoft.AspNetCore.Identity;
namespace ButterflyCarair.Models
{
    public class User:IdentityUser{
        public string FullName {get;set;} =null!;
    }
}