using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Core.DataAccess.Concrete.EntityFramework;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.Entities.Concrete;

namespace UnitOfWork.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
