using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.GenericRepository;
using Services.Services;

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
		[Route("GetUserById")]
		public ActionResult<User> GetUserById(int id)
		{
			return this.genericRepository.GetById(id);
		}

		[HttpPost]
		[Route("PostUser")]
		public ActionResult<User> PostUser(User user)
		{
			this.genericRepository.Add(user);

			return user;
		}

		[HttpPost]
		[Route("Login")]
		public ActionResult<bool> Login(string userName, string password)
		{
			return this.userService.Login(userName, password);
		}

		[HttpPut]
		[Route("UpadteUser")]
		public void PutUser(User user)
		{
			this.genericRepository.Update(user);
		}

		[HttpDelete]
		[Route("DeleteUser")]
		public ActionResult DeleteUser(int userId)
		{
			this.userService.LogicDelete(userId);
			return Ok();
		}

		[HttpGet]
		[Route("GetAllUser")]
		public ActionResult<List<User>> GetAllUser()
		{
			return this.genericRepository.GetAll();
		}
	}
}
