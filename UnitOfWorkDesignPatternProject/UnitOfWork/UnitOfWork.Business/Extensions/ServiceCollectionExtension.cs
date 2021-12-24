using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Business.Abstract;
using UnitOfWork.Business.AutoMapper.Profiles;
using UnitOfWork.Business.Concrete;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Concrete.EntityFramework.Contexts;

namespace UnitOfWork.Business.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddAutoMapper(typeof(CategoryProfile));
            serviceCollection.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connectionString));
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork.DataAccess.Concrete.UnitOfWork>();
            serviceCollection.AddTransient<ICategoryService, CategoryManager>();

            return serviceCollection;
        }
    }
}
