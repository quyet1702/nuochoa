using System;
using System.Collections.Generic;

namespace ButterflyCarair.Models
{
    public partial class New
    {
        public int Id { get; set; }
        public string? Avatar { get; set; } = null!;
        public string? Title { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Descriptions { get; set; }
        public string? Details { get; set; }
    }
}
