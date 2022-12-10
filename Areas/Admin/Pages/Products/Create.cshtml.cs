using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ButterflyCarair.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace ButterflyCarair.Areas_Admin_Pages_Product
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly ButterflyCarair.Models.but73756_butterflycarairContext _context;

        public CreateModel(ButterflyCarair.Models.but73756_butterflycarairContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Notification {get;set;} ="1";
        [BindProperty]
        public Product Product { get; set; }
        [BindProperty]
        [Required(ErrorMessage="Không được để trống")]
        public Scent[] Scents { get; set; }
        public bool IsSuccess { get; set; } = false;
        public List<SelectListItem> productTypes { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "Chọn loại sản phẩm" },
        new SelectListItem { Value = "1", Text = "Kẹp cửa gió" },
        new SelectListItem { Value = "2", Text = "Đặt Taplo"  },
        new SelectListItem { Value = "3", Text = "Treo"  },
        new SelectListItem { Value = "4", Text = "Xịt"  },
    };
    public List<SelectListItem> Sex { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "Chọn giới tính" },
        new SelectListItem { Value = "Nam", Text = "Nam" },
        new SelectListItem { Value = "Nữ", Text = "Nữ" },
        new SelectListItem { Value = "Nam và nữ", Text = "Nam và nữ" },
    };
    public List<SelectListItem> PromotionTypes { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "Chọn đơn vị" },
        new SelectListItem { Value = "%", Text = "%" },
        new SelectListItem { Value = "VNĐ", Text = "VNĐ" },
    };

    [BindProperty]
     [Required(ErrorMessage="Không được để trống")]
    public IFormFile UploadAvatar {get;set;}
    [BindProperty]
     [Required(ErrorMessage="Không được để trống")]
    public IFormFile UploadImage1 {get;set;}
    [BindProperty]
     [Required(ErrorMessage="Không được để trống")]
    public IFormFile UploadImage2 {get;set;}
    [BindProperty]
     [Required(ErrorMessage="Không được để trống")]
    public IFormFile UploadImage3 {get;set;}
    [BindProperty]
    public IFormFile? UploadImage4 {get;set;}

      
        public IActionResult OnGet()
        {
            return Page();
        }
        public void OnPostAddForm(){
            
        }
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                IsSuccess=false;
                return Page();
            }
            var product1 = _context.Products.Include(s=>s.Scents).Where(p=>p.Name==Product.Name).FirstOrDefault();
            if(product1==null){
                if(UploadAvatar!=null){
                    Product.Avatar = Path.Combine("images","product",Product.Name.Replace(" ","-")+"Avatar"+ UploadAvatar.ContentType.Replace("image/","."));
                    UploadFile(UploadAvatar, Product.Avatar);
                }
                if(UploadImage1!=null){
                    Product.Image1 =  Path.Combine("images","product",Product.Name.Replace(" ","-")+"1"+ UploadImage1.ContentType.Replace("image/","."));
                    UploadFile(UploadImage1,Product.Image1);
                }
                if(UploadImage2!=null){
                    Product.Image2 =  Path.Combine("images","product",Product.Name.Replace(" ","-")+"2"+ UploadImage2.ContentType.Replace("image/","."));
                    UploadFile(UploadImage2,Product.Image2);
                }
                if(UploadImage3!=null){
                    Product.Image3 =  Path.Combine("images","product",Product.Name.Replace(" ","-")+"3"+ UploadImage3.ContentType.Replace("image/","."));
                    UploadFile(UploadImage3,Product.Image3);
                }
                if(UploadImage4!=null){
                    Product.Image4 =  Path.Combine("images","product",Product.Name.Replace(" ","-")+"4"+ UploadImage4.ContentType.Replace("image/","."));
                    UploadFile(UploadImage4,Product.Image4);
                }
                if(Product.Describe is not null){
                    Product.Describe = Product.Describe.Substring(0);
                }
                if(Product.UsageAndCare is not null){
                    Product.UsageAndCare = Product.UsageAndCare.Substring(0);
                }
                Product.Sold = 0;
                if(Scents.Length >0){
                    Product.Scents = Scents;
                }
                _context.Add(Product);
                await _context.SaveChangesAsync();
                Notification = "Thêm sản phẩm thành công";
                IsSuccess=true;
                return RedirectToPage("/Index");
            }
            else{
                // if(product1.Scents.Count>0){
                //     foreach(var item in product1.Scents){
                //         if(item.ScentName==Scent.ScentName){
                //             IsSuccess=false;
                //             return Page();
                //         }
                //     }
                // };
                ModelState.AddModelError(string.Empty, "Tên sản phẩm đã tồn tại");
                return Page();
            }
        }
        void UploadFile(IFormFile file,string ImageName){
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",ImageName);
            using(var fileStream = new FileStream(path, FileMode.Create)){
                file.CopyTo(fileStream);
            }
        }
    }
}
