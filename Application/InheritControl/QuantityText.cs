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
    public partial class QuantityText : TextBox
    {
        public QuantityText()
        {
            InitializeComponent();
            this.KeyPress += QuantityText_KeyPress;
        }

        private void QuantityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
