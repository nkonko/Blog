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
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions<BlogContext> options)
		{

		}
		public DbSet<User> Users { get; set; }
	}
}
