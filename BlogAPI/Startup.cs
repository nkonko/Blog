using Data.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BlogAPI.ContextFactory;
using Services.GenericRepository;
using Domain;

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
			services.AddTransient<IGenericRepository<User>, GenericRepository<User>>(); /// CHECK THIS METHOD MOTHERFUCKER...!!!
			////services.AddDbContext<PUT DB CONTEXT HERE>(x => x.UseNpgsql(configuration.GetConnectionString("Postgre")));
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
			services.AddControllers();
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();
		}
	}
}
