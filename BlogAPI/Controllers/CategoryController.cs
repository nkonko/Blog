using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.GenericRepository;

namespace BlogAPI.Controllers
{
	public class CategoryController : BaseApiController
	{
		private readonly IGenericRepository<Category> genericRepository;

		public CategoryController(IGenericRepository<Category> genericRepository)
		{
			this.genericRepository = genericRepository;
		}

		[HttpGet]
		[Route("GetCategory")]
		public ActionResult<Category> GetCategory(int id)
		{
			return this.genericRepository.GetById(id);
		}

		[HttpPost]
		[Route("CreateNewCategory")]
		public ActionResult<Category> CreateNewCategory(Category category)
		{
			this.genericRepository.Add(category);
			return category;
		}

		[HttpPut]
		[Route("UpdateCategory")]
		public void UpdateCategory(Category category)
		{
			this.genericRepository.Update(category);
		}

		[HttpDelete]
		[Route("DeleteCategory")]
		public void DeleteCategory(int id)
		{
			this.genericRepository.Delete(id);
		}
	}
}
