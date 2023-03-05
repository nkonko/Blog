using Data.AppContext;
using Domain;
using Microsoft.EntityFrameworkCore;
using Services.GenericRepository;

namespace Services
{
	public class UserService : IUserService
	{
		private readonly IGenericRepository<User> genericRepository;

		public UserService(IGenericRepository<User> genericRepository)
		{
			this.genericRepository = genericRepository;
		}

		public void LogicDelete(int userId)
		{
			var user = this.genericRepository.GetById(userId);

			if (user != null)
			{
				user.Deleted = true;
				genericRepository.Update(user);
			}
		}

		public bool Login(string userName, string password)
		{
			var users = GetByUserNameAndPassword(userName, password);

			return users != null;
		}
		private User? GetByUserNameAndPassword(string userName, string password)
		{
			try
			{
				var response = this.genericRepository.GetAll().FirstOrDefault(u => u.UserName == userName && u.Password == password)!;

				if (response != null)
				{
					return response;
				}

				////**** AGREGAR LOG PARA INDICAR QUE HUBO UN INTENTO DE SESION CON UN USUARIO INCORRECTO ***//// 

				return null;

			}
			catch (Exception)
			{

				throw; //AGREAGARLO PARA INDICAR QUE HUBO UN PROBLEMA CON LA DB...
			}

		}

	}
}
