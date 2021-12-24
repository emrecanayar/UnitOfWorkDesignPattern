using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities.Concrete;

namespace UnitOfWork.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }
    }
}
