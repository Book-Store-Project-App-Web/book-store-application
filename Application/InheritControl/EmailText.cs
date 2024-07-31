using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritControl
{
    public class EmailText : TextBox
    {
        private ErrorProvider errorProvider;

        public EmailText()
        {
            this.KeyPress += EmailText_KeyPress;
            this.errorProvider = new ErrorProvider();
            this.Validating += EmailText_Validating;
        }

        private void EmailText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void EmailText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = this.Text.Trim();
            Regex regex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");

            if (string.IsNullOrWhiteSpace(email) || !regex.IsMatch(email))
            {
                errorProvider.SetError(this, "Địa chỉ email không hợp lệ.");
                
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(this, string.Empty);
            }
        }
    }
}
