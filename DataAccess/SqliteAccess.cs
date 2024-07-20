using Dapper;
using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.DataAccess
{
    public class SqliteAccess<T> : ISqliteAccess<T> where T : class
    {
        public List<T> LoadData()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<T>($"select * from {nameof(T)}", new DynamicParameters());
                return result.ToList();
            }
        }

        public void Create(T Value)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                if (typeof(T).Equals(typeof(IProducts)))
                {
                    con.Execute($"insert into {nameof(T)} (Name,CategoryId,Price,Quantity,Price) values (@Name, @CategoryId, @Price, @Quantity)", Value);
                }
                else
                {
                    con.Execute($"insert into {nameof(T)} (Name,Total) values (@Name, @Total)", Value);
                }

            }
        }

        public string LoadConnectionString(string id = "InventoryApplication.Properties.Settings.DefaultConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
