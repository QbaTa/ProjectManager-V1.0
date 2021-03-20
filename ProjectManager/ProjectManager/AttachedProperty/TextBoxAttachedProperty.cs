using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    static class TextBoxAttachedProperty
    {
        public static void ChangePropertyClickPasswordBox(TextBox _textBoxUsername, TextBox _textBoxPass)
        {
            if(String.IsNullOrEmpty(_textBoxUsername.Text))
                _textBoxUsername.Text = "Username";
            if(_textBoxPass.Text.Equals("Password"))
            {
                _textBoxPass.Text = String.Empty;
                _textBoxPass.PasswordChar = '•';
            }
        }

        public static void ChangePropertyClickTextBox(TextBox _textBoxUsername, TextBox _textBoxPass)
        {
            if(String.IsNullOrEmpty(_textBoxPass.Text))
            {
                _textBoxPass.Text = "Password";
                _textBoxPass.PasswordChar = '\0';
            }
            if(_textBoxUsername.Text.Equals("Username"))
            {
                _textBoxUsername.Text = String.Empty;
            }
        }
    }
}
