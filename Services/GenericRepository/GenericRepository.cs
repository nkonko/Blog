using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;

namespace Services.GenericRepository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly BlogContext blogContext;
		public async Task<T> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<T> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<T> Insert(T entity)
		{
			throw new NotImplementedException();
		}

		public async Task<T> Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
