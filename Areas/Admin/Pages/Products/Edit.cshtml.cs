using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ButterflyCarair.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace ButterflyCarair.Areas_Admin_Pages_Product
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly ButterflyCarair.Models.but73756_butterflycarairContext _context;

        public EditModel(ButterflyCarair.Models.but73756_butterflycarairContext context)
        {
            _context = context;
        }
        [BindProperty]
        [Required(ErrorMessage="Không được để trống")]
        public Scent[] Scents { get; set; }
        [BindProperty]
        public string? Describe { get; set; }
        [BindProperty]
        public Product Product { get; set; } = default!;
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

        [BindProperty]
        public IFormFile? UploadAvatar {get;set;}
        [BindProperty]
        public IFormFile? UploadImage1 {get;set;}
        [BindProperty]
        public IFormFile? UploadImage2 {get;set;}
        [BindProperty]
        public IFormFile? UploadImage3 {get;set;}
        [BindProperty]
        public IFormFile? UploadImage4 {get;set;}
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }
            Product =  await _context.Products.Include(p=>p.Scents).FirstOrDefaultAsync(m => m.Id == id);
            Scents = Product.Scents.ToArray();
            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
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
            List<Scent> Scents1 = new List<Scent>();
            if (Scents.Length >= 0)
            {
                Scents1 = _context.Scents.ToList().Where(value=>{return
                        (!Scents.ToList().Any(p=>p.Id==value.Id));}).ToList();
            }
            List<Scent> scents2 = new  List<Scent>();
            _context.Scents.ToList().ForEach(p=>{
                for(int i =0; i<Scents.Length;i++){
                    if(p.Id==Scents[i].Id){
                        p.ProductCode= Scents[i].ProductCode;
                        p.ScentName= Scents[i].ScentName;
                        _context.Attach(p).State = EntityState.Modified;
                    }
                }
            });
            Scents.ToList().ForEach(value=> {
                if(!(_context.Scents.ToList().Any(p=>p.Id ==value.Id))){
                    value.ProductId = Product.Id;
                     _context.Scents.Add(value);
                }
            });
            _context.Scents.RemoveRange(Scents1);
            await _context.SaveChangesAsync();
            _context.Attach(Product).State = EntityState.Modified;
            try
            {
                
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(int id)
        {
          return _context.Products.Any(e => e.Id == id);
        }
        void UploadFile(IFormFile file,string ImageName){
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",ImageName);
            using(var fileStream = new FileStream(path, FileMode.Create)){
                file.CopyTo(fileStream);
            }
        }
    }
}
