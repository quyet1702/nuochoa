using ButterflyCarair.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<but73756_butterflycarairContext>();

builder.Services.AddIdentity<User,IdentityRole>()
                	.AddEntityFrameworkStores<but73756_butterflycarairContext>()
                	.AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions> (options => {
	options.Password.RequireDigit = false; // Không bắt phải có số
	options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
	options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
	options.Password.RequireUppercase = false; // Không bắt buộc chữ in
	options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
    options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
    options.SignIn.RequireConfirmedPhoneNumber = true;     // Xác thực số điện thoại

});
builder.Services.ConfigureApplicationCookie (options => {
    		// options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    		options.LoginPath = $"/Admin/Account/UserManager/Login";	
   			options.LogoutPath = $"/logout/";				
    		options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
	});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints (endpoints => {
                endpoints.MapControllerRoute (
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); 
            });
app.MapRazorPages();

app.Run();
