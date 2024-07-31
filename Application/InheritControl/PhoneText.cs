using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritControl
{
    public partial class PhoneText : TextBox
    {
        ErrorProvider errorProvider;
        public PhoneText()
        {
            InitializeComponent();
            this.KeyPress += PhoneText_KeyPress;
            errorProvider = new ErrorProvider();
        }

        private void PhoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ValidatePhoneNumber();
        }
        private void ValidatePhoneNumber()
        {
            if (this.Text.Length > 10)
            {
                errorProvider.SetError(this, "Số điện thoại không được vượt quá 10 số.");
            }
            else
            {
                errorProvider.SetError(this, string.Empty);
            }
        }
    }
}
