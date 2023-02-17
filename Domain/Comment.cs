using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Comments { get; set; }//No permite colocar el mismo nombre que la clase
        public string? Email { get; set; }
        public int Post_id { get; set; }
        public DateTime? Created_at { get; set; }
        public int? Status { get; set; }
    }
}
