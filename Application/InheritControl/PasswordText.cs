using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InheritControl
{
    public partial class PasswordText : TextBox
    {
        ErrorProvider errorProvider;
        public PasswordText()
        {
            InitializeComponent();
            this.KeyPress += PasswordText_KeyPress;
            this.errorProvider = new ErrorProvider();
        }

        private void PasswordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string pattern = @"^(?=.*[A-Z])(?=.*\W).{6,}$";
            //if (Regex.IsMatch(this.Text, pattern))
            //{
            //    errorProvider.Clear();
            //}
            //else
            //{
            //    errorProvider.SetError(this, "Password must be 6 characters or more, including 1 uppercase letter and 1 special character");
            //}
        }

    }
}
