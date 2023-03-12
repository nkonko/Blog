using Data.Encryption;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.GenericRepository;
using Services.Services;
using System.Security.Cryptography;

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
			var loginList = new List<string>();
			loginList.Add(user.UserName!);
			loginList.Add(user.Password!);
			var result = Encrypt.GetSHA1(loginList);
			user.UserName = result[0];
			user.Password = result[1];

			this.genericRepository.Add(user);

			return user;
		}

		[HttpPost]
		[Route("Login")]
		public ActionResult<bool> Login(string userName, string password)
		{
            var loginList = new List<string>();
            loginList.Add(userName);
            loginList.Add(password);
            var result = Encrypt.GetSHA1(loginList);
            userName = result[0];
            password = result[1];
            return this.userService.Login(userName, password);
		}

		[HttpPut]
		[Route("UpadteUser")]
		public ActionResult PutUser(User user)
		{
			this.genericRepository.Update(user);
			return Ok();
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
