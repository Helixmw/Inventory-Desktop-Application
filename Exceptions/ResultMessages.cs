using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Exceptions
{
    public static class ResultMessages
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message,"Application Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        public static void ShowGeneralError()
        {
            MessageBox.Show("Something went wrong. Unable to process this task", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowInputError(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowQuestion(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
