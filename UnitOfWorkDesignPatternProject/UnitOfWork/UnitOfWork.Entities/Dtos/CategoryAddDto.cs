using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Entities.Dtos
{
    public class CategoryAddDto
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }

    }
}
