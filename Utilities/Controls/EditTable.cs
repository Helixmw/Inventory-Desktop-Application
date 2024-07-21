using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities.Controls
{
    public static class EditTable
    {
        public static void InsertProductRow(DataGridView dataGridView, Products product)
        {
           dataGridView.Rows.Add(product);
        }
    }
}
