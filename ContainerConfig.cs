using Autofac;
using InventoryApplication.DataAccess;
using InventoryApplication.Models;
using InventoryApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Products>().As<IProducts>();
            builder.RegisterType<Categories>().As<ICategories>();
            //builder.RegisterType<CategoryDataAccess<IProducts>>();
            //builder.RegisterType<CategoryDataAccess<ICategories>>();
            builder.RegisterType<ProductsRepository>().As<IProductsRepository>();
            builder.RegisterType<CategoriesRepository>().As<ICategoriesRepository>();

            return builder.Build();
        }
    }
}
