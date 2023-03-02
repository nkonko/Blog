using Data.AppContext;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Services.GenericRepository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private readonly BlogContext blogContext;

		public GenericRepository(BlogContext blogContext)
		{
			this.blogContext = blogContext;
		}
		public void Add(T entity)
		{
			this.blogContext.Set<T>().Add(entity);
            this.blogContext.Entry(entity).State = EntityState.Added;
			this.blogContext.SaveChangesAsync();
        }

		public void Delete(T entity)
		{
			this.blogContext.Set<T>().Remove(entity);
            this.blogContext.Entry(entity).State = EntityState.Deleted;
            this.blogContext.SaveChangesAsync();
        }

		public async Task<IReadOnlyList<T>> GetAll()
		{
			return await this.blogContext.Set<T>().ToListAsync();
		}

		public async Task<T> GetById(int id)
		{
			return await this.blogContext.Set<T>().FindAsync(id);
		}

		public void Update(T entity)
		{
			this.blogContext.Set<T>().Attach(entity);
			this.blogContext.Entry(entity).State = EntityState.Modified;
            this.blogContext.SaveChangesAsync();
        }
	}
}
