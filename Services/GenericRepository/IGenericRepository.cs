using Domain;

namespace Services.GenericRepository
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		void Add(T entity);

		void Update(T entity);

		void Delete(int id);
		
		List<T> GetAll();

		T GetById(int id);
	}
}
