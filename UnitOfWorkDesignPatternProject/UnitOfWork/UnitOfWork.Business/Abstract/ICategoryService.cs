using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities.Dtos;

namespace UnitOfWork.Business.Abstract
{
    /// <summary>
    /// UnitOfWork örnek olması amaçlı oluşturulmuştur. Result yapısı şişme yapmasın diye eklenmemiştir.
    /// </summary>
    public interface ICategoryService
    {
        public Task<CategoryListDto> GetAllCategoriesAsync();
        public Task<CategoryDto> GetByIdCategoryAsync(int id);
        public Task CreateAsync(CategoryAddDto categoryAddDto);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<int> SaveAsync();
    }
}