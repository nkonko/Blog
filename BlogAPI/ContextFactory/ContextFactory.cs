using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;
using Data.AppContext;

namespace BlogAPI.ContextFactory
{
	public class BlogContextFactory : IDesignTimeDbContextFactory<BlogContext>
	{
		private readonly IConfiguration configuration;

		public BlogContextFactory(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public BlogContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<BlogContext>();
			var connectionString = this.configuration.GetConnectionString("Postgre");
			builder.UseNpgsql(connectionString, builder => builder.MigrationsAssembly("BlogAPI"));

			return new BlogContext(builder.Options);
		}


	}
}
