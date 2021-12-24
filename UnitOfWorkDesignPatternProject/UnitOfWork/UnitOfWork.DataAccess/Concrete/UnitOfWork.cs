using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Concrete.EntityFramework.Contexts;
using UnitOfWork.DataAccess.Concrete.EntityFramework.Repositories;

namespace UnitOfWork.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext _context;
        private EfCategoryRepository _categoryRepository;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
        }
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();

        public async ValueTask DisposeAsync() => await _context.DisposeAsync();
        public async Task<int> SaveAsync()
        {
            var result = await _context.SaveChangesAsync();
            return result;
        }
    }




}
