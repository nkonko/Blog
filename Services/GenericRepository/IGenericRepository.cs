using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services.GenericRepository
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		IReadOnlyList<T> GetAll();
		T GetById(int id);
	}
}
