using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Brief { get; set; }
        public string? Content { get; set; }
        public string? Image { get; set; }
        public DateTime? Created_at { get; set; }
        public int? Status { get; set; }
        public int Category_id { get; set; }
        public int User_id { get; set; }
    }
}
