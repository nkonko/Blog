using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.AppContext

{
	public class AppContext : DbContext
	{
		private readonly IConfiguration configuration;

		public AppContext(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseNpgsql(this.configuration.GetConnectionString("Postgre"));
		}

		public DbSet<User> Users { get; set; }
	}
}
