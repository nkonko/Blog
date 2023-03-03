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
