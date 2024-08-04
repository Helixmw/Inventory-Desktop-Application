using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities.Controls
{
    internal static class Prompts
    {
        public static DialogResult QuestionPrompt(string question, string? caption)
        {
            return MessageBox.Show(question,caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
