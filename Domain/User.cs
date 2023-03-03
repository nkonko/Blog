using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("User")]
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public bool? Deleted { get; set; }
    }
}
