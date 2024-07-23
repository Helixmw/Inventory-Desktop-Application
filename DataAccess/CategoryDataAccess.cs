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

        public Categories Create(string Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                 con.Execute($"insert into Categories (Name) values (@Name)", new Categories() { Name = Value });
                var result = con.Query<Categories>("select * from Categories", new DynamicParameters());
                return result.Last();

            }
        }

        public string LoadConnectionString(string id = "InventoryApplication.Properties.Settings.DefaultConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
