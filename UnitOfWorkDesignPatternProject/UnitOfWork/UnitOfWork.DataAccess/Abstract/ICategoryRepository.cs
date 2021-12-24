using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Core.DataAccess.Abstract;
using UnitOfWork.Entities.Concrete;

namespace UnitOfWork.DataAccess.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {

    }
}
