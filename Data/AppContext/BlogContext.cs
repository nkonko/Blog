using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.AppContext

{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions<BlogContext> options) : base(options)
		{

		}

		public DbSet<User> Users { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Comment> Comment { get; set; }
		public DbSet<Post> Post { get; set; }
	}
}
