using BlogAPI.ContextFactory;
using Data.AppContext;
using Domain;
using Microsoft.EntityFrameworkCore.Design;
using Services.GenericRepository;

namespace BlogAPI
{
	public class Startup
	{
		private readonly IConfiguration configuration;

		public Startup(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IDesignTimeDbContextFactory<BlogContext>, BlogContextFactory>();
			services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
			////services.AddDbContext<PUT DB CONTEXT HERE>(x => x.UseNpgsql(configuration.GetConnectionString("Postgre")));
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
			services.AddControllers();
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();
		}
	}
}
