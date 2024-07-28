using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InheritControl
{
    public class EmailText : TextBox
    {
        ErrorProvider errorProvider;
        public EmailText()
        {
            this.KeyPress += EmailText_KeyPress;
            //this.errorProvider = new ErrorProvider();
        }

        private void EmailText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            //String email = this.Text;
            //Match match = regex.Match(email);

            //if (match.Success)
            //{
            //    errorProvider.Clear();
            //}
            //else
            //{
            //    errorProvider.SetError(this, "Ivalid Email");
            //}
        }
    }
}
