using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class Library
    {
        public Library()
        {
        }

        public bool AreControlsValid(Control parentControl, ErrorProvider errorProvider, params string[] textBoxNames)
        {
            bool isValid = true;
            errorProvider.Clear();

            foreach (string name in textBoxNames)
            {
                Control[] controls = parentControl.Controls.Find(name, true);
                if (controls.Length > 0 && controls[0] is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        errorProvider.SetError(textBox, $"Vui lòng nhập {name.Replace("txt", "")}.");
                        isValid = false;
                    }
                }
            }

            return isValid;
        }
    }
}
