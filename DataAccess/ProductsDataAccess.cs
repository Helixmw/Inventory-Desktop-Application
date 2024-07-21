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

        public Products Create(Products Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"insert into Products (Name,CategoryId,Price,Quantity,CreatedDate) values (@Name, @CategoryId, @Price, @Quantity, @CreatedDate)", Value);
                return GetPreviouslyEntered();            
    
            }
        }

        private Products GetPreviouslyEntered()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<Products>("select * from Products", new DynamicParameters());
                return result.Last();
            }
        }

        public void UpdateProduct(Products Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"update Products set Name = @Name, CategoryId = @CategoryId, Quantity = @Quantity, Price = @Price where ProductId = {Value.ProductId}", Value);
            }
            
        }

        public void DeleteProduct(int id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"delete from Products where ProductId = {id}");
            }
        }

        public string LoadConnectionString(string id = "InventoryApplication.Properties.Settings.DefaultConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

