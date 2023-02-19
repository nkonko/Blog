using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public string? Email { get; set; }
        public int Post_id { get; set; }
        public DateTime? Created_at { get; set; }
        public int? Status { get; set; }
    }
}
