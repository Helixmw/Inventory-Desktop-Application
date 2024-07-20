using Autofac;
using InventoryApplication.DataAccess;
using InventoryApplication.Models;
using InventoryApplication.Utilities;

namespace InventoryApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                //scope.Resolve<CategoryDataAccess<IProducts>>();
                //scope.Resolve<CategoryDataAccess<ICategories>>();
                scope.Resolve<ICategoriesRepository>();
                scope.Resolve<IProductsRepository>();
            }
            Application.Run(new Form1());
        }
    }
}