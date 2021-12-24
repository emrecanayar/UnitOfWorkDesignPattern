using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities.Concrete;

namespace UnitOfWork.Entities.Dtos
{
    public class CategoryListDto
    {
        public IList<Category>? Categories { get; set; }
    }
}
