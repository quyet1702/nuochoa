using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ButterflyCarair.Models
{
    public partial class Product
    {
        public Product()
        {
            Scents = new HashSet<Scent>();
        }

        public int Id { get; set; }
        public string? Avatar { get; set; }
         [StringLength(100, MinimumLength = 8, ErrorMessage="Tên sản phẩm phải từ {2} đến {1} ký tự")]
        [Required(ErrorMessage="Không được để trống")]
        public string Name { get; set; } =null!;
        public int? Price { get; set; }
        public int? Sold { get; set; }
        public int? ProductLocation { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public int? Weight { get; set; }
        public string? Trademark { get; set; }
        public string? Sex { get; set; }
        public string? Concentration { get; set; }
        public string? PerfumeType { get; set; }
        public string? Style { get; set; }
        public string? ReleaseYear { get; set; }
        public string? Origin { get; set; }
        [Required(ErrorMessage="Vui lòng chọn loại sản phẩm")]
        public string ProductType { get; set; }
        public bool Promotion { get; set; } = false;
        [Required(ErrorMessage="Không được để trống")]
        public string Describe { get; set; }
        [Required(ErrorMessage="Không được để trống")]
        public string UsageAndCare { get; set; }
        public virtual ICollection<Scent> Scents { get; set; }
    }
}
