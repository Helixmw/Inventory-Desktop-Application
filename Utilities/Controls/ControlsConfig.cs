using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication.Utilities.Controls
{
    public static class ControlsConfig
    {
        public static void ConfigureDataGridsAndToolStrip(DataGridView dataGridView1, DataGridView dataGridView2, ToolStripStatusLabel toolStripStatusLabel)
        {
            toolStripStatusLabel.Text = string.Empty;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }

        public static void ResetTextFieldsAndResetButton(TextBox prodName, NumericUpDown prodQuantity, NumericUpDown prodPrice, Button resetButton)
        {
            prodName.Text = string.Empty;
            prodQuantity.Value = 1;
            prodPrice.Value = 0;
            resetButton.Enabled = false;
        }
       
    }
}
