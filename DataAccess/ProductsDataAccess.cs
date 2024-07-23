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
using System.Drawing;

namespace InventoryApplication.DataAccess
{
    public class ProductsDataAccess
    {
        public List<Products> LoadData()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<Products>("select * from Products", new DynamicParameters());
                return result.ToList();
            }
        }

        public async Task<Products> Create(Products Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"insert into Products (Name,CategoryId,Price,Quantity,CreatedDate) values (@Name, @CategoryId, @Price, @Quantity, @CreatedDate)", Value);
                var previous = await Task.Run(() => GetPreviouslyEntered());   
                return previous;
    
            }
        }

        private Products GetPreviouslyEntered()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<Products>("select * from Products", new DynamicParameters());
                var last = result.Last();
                //var category = con.Query<Categories>($"select * from Categories where CategoryId = {last.CategoryId}").First();
                //category.Total += 1;
                con.Execute($"update Categories set Total = Total + 1 where CategoryId = {last.CategoryId}", new Categories() { CategoryId = last.CategoryId});
                return last;

            }
        }

        public async void UpdateProduct(Products Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
            await Task.Run(() => CheckIfCategoryIdStillTheSameForProduct(con, Value.CategoryId, Value.ProductId));
                con.Execute($"update Products set Name = @Name, CategoryId = @CategoryId, Quantity = @Quantity, Price = @Price where ProductId = {Value.ProductId}", Value);
            }
            
        }

        private void CheckIfCategoryIdStillTheSameForProduct(IDbConnection con, int CategoryId, int ProductId)
        {
                var product = con.Query<Products>($"select * from Products where ProductId = {ProductId}", new DynamicParameters()).First();
                if (CategoryId != product.CategoryId) //product.CategoryId = Previous Category Id
                {
                con.Execute($"update Categories set Total = Total - 1 where CategoryId = {product.CategoryId}", new Categories() { CategoryId = product.CategoryId });
                    //var category = con.Query<Categories>($"select * from Categories where CategoryId = {product.CategoryId}").First();
                    //var new_total = category.Total -= 1;
                    //con.Execute($"update Categories set Total = {new_total} where CategoryId = {product.CategoryId}", new Categories() { Total = new_total });
                }
            
        }

        private void SubtractCategoryWhenProductDeleted(IDbConnection con, int CategoryId)
        {
            con.Execute($"update Categories set Total = Total - 1 where CategoryId = {CategoryId}", new Categories() { CategoryId = CategoryId });
        }

        public async Task DeleteProduct(Products product)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                await Task.Run(() => SubtractCategoryWhenProductDeleted(con, product.CategoryId));
                con.Execute($"delete from Products where ProductId = {product.ProductId}");
            }
        }



        public string LoadConnectionString(string id = "InventoryApplication.Properties.Settings.DefaultConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

