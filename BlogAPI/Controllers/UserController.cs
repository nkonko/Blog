using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.GenericRepository;

namespace BlogAPI.Controllers
{
	public class UserController : BaseApiController
	{
		private readonly IGenericRepository<User> genericRepository;
		private readonly IUserService userService;

		public UserController(IGenericRepository<User> genericRepository, IUserService userService)
		{
			this.genericRepository = genericRepository;
			this.userService = userService;
		}

		[HttpGet]
		public ActionResult<User> GetUserById(int id)
		{
			return genericRepository.GetById(id);
		}

		[HttpPost]
		public ActionResult<User> PostUser(User user)
		{
			this.genericRepository.Add(user);
			return user;
		}

		[HttpPost]
		public ActionResult<bool> Login(string userName, string password)
		{
			return userService.Login(userName, password);
		}
	}
}
