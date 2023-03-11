using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
	[Table("Category")]
	public class Category : BaseEntity
	{
		public string? Name { get; set; }
	}
}