using Data.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlogAPI.ContextFactory
{
	public class BlogContextFactory : IDesignTimeDbContextFactory<BlogContext>
	{
		public BlogContextFactory()
		{
		}

		public BlogContext CreateDbContext(string[] args)
		{
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BlogContext>();
			var connectionString = configuration.GetConnectionString("Postgre");
			builder.UseNpgsql(connectionString, builder => builder.MigrationsAssembly("BlogAPI"));

			return new BlogContext(builder.Options);
		}
	}
}
