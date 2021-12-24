using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Business.Abstract;

namespace UnitOfWork.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [Route("api/[controller]/[action]")]
        public async Task<IActionResult> DatabaseBusiness()
        {
            try
            {
                await _categoryService.CreateAsync(new Entities.Dtos.CategoryAddDto
                {
                    CategoryName = "Test",
                    Description = "Test",
                });
                await _categoryService.UpdateAsync(new Entities.Dtos.CategoryUpdateDto
                {
                    CategoryID = 1,
                    CategoryName = "Updated Test",
                    Description = "Updated Test",

                });
                await _categoryService.DeleteAsync(9);
                await _categoryService.SaveAsync();
                return Ok();
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }
    }
}
