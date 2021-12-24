using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Business.Abstract;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.Entities.Concrete;
using UnitOfWork.Entities.Dtos;

namespace UnitOfWork.Business.Concrete
{
    public class CategoryManager : ManagerBase, ICategoryService
    {
        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task CreateAsync(CategoryAddDto categoryAddDto)
        {
            using var transaction = await UnitOfWork.BeginTransactionAsync();
            var category = Mapper.Map<Category>(categoryAddDto);
            var addedCategory = UnitOfWork.Categories.AddAsync(category);
            await transaction.CommitAsync();
        }

        public async Task UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            using var transaction = await UnitOfWork.BeginTransactionAsync();
            var category = Mapper.Map<Category>(categoryUpdateDto);
            var updatedCategory = UnitOfWork.Categories.UpdateAsync(category);
            await transaction.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            using var transaction = await UnitOfWork.BeginTransactionAsync();
            var category = await UnitOfWork.Categories.GetAsync(c => c.CategoryID == id);
            await UnitOfWork.Categories.DeleteAsync(category);
            await transaction.CommitAsync();
        }

        public async Task<CategoryListDto> GetAllCategoriesAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync();
            var result = Mapper.Map<CategoryListDto>(categories);
            return result;
        }

        public async Task<CategoryDto> GetByIdCategoryAsync(int id)
        {
            var categories = await UnitOfWork.Categories.GetAsync(c => c.CategoryID == id);
            var result = Mapper.Map<CategoryDto>(categories);
            return result;
        }

        public async Task<int> SaveAsync()
        {
            var result = await UnitOfWork.SaveAsync();
            return result;
        }
    }
}
