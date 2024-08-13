using Dapper;
using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.DataAccess
{
    public class CategoryDataAccess
    {
        public List<Categories> LoadData()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<Categories>("select * from Categories", new DynamicParameters());
                return result.ToList();
            }
        }

        public List<Categories> Create(string Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                 con.Execute($"insert into Categories (Name) values (@Name)", new Categories() { Name = Value });
                var categories = LoadNewData(con);
                return categories;

            }
        }

        private List<Categories> LoadNewData(IDbConnection con)
        {
            var categories  = con.Query<Categories>("select * from Categories", new DynamicParameters());
            return categories.ToList();
        }

        public Boolean Update(Categories categories)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Execute($"update categories set Name = '{categories.Name}' where CategoryId = {categories.CategoryId}") > 0;
            }
        }

        public List<Categories> DeleteProductsUnderCategory(Categories category)
        {
            using(IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                ResetCategory(con, category);
                con.Execute($"delete from Products where CategoryId = {category.CategoryId}");
                var categories = LoadNewData(con);
                return categories;
            }
        }

        public List<Categories> Delete(Categories category) {
            using(IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                ResetCategory(con, category);
                con.Execute($"delete from Categories where CategoryId = {category.CategoryId}");
                var categories = LoadNewData(con);
                return categories;
            }
        }

        public List<Categories> DeleteAllCategoryData(Categories category)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"delete from Categories where CategoryId = {category.CategoryId}");
                DeleteProductsUnderCategory(con, category);
                var categories = LoadNewData(con);
                return categories;
            }
        }

        private void DeleteProductsUnderCategory(IDbConnection con, Categories category)
        {
            con.Execute($"delete from Products where CategoryId = {category.CategoryId}");
        }


        private void ResetCategory(IDbConnection con, Categories category)
        {
            con.Execute($"update Categories set Total = 0 where CategoryId = {category.CategoryId}");
        }

        public string LoadConnectionString(string id = "InventoryApplication.Properties.Settings.DefaultConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
