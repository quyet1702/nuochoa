using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ButterflyCarair.Models
{
    public partial class Scent
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Không được để trống")]
        public string ScentName { get; set; } = null!;
        public int? ProductId { get; set; }
        [Required(ErrorMessage="Không được để trống")]
        public string ProductCode { get; set; } = null!;
        public virtual Product? Product { get; set; }
    }
}
