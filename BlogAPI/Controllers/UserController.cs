using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.GenericRepository;

namespace BlogAPI.Controllers
{
	public class UserController : BaseApiController
	{
		private readonly IGenericRepository<User> genericRepository;

		public UserController(IGenericRepository<User> genericRepository)
		{
			this.genericRepository = genericRepository;
		}

		[HttpGet]

		public async Task<ActionResult<User>> GetUserById(int id)
		{
			return await genericRepository.GetById(id);
		}

		[HttpPost]

		public ActionResult<User> PostUser(User user)
		{
			this.genericRepository.Insert(user);
			//this.genericRepository.SaveChangesAsync();

			return user;
		}
	}
}
