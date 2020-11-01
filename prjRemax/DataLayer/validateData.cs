using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace prjRemax.DataLayer
{
    class validateData
    {
        public validateData() { }

        public static bool isEmailValid(TextBox email)
        {
            if (email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email Can not be empty");
                email.Focus();
                return false;
            }
            bool reg = Regex.IsMatch(email.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (reg == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email Address is not Valid");
                email.Focus();
                return false;
            }
        }

        public static bool isNameValid(TextBox name)
        {
            if (name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name Can not be empty");
                name.Focus();
                return false;
            }
            bool reg = Regex.IsMatch(name.Text, @"^[A-Za-z]+([\ A-Za-z]+)*\Z", RegexOptions.IgnoreCase);
            if (reg == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Name is not valid");
                return false;
            }

        }

        public static bool isPhoneNumberValid(TextBox phone)
        {
            if (phone.Text.Trim().Length != 10)
            {
                MessageBox.Show("Phone Number should be 10 Digits");
                phone.Focus();
                return false;
            }
            return true;
        }

        public static bool isComboBoxSelected(ComboBox combo)
        {
            if (combo.SelectedIndex >= 0)
            {
                return true;
            }
            MessageBox.Show("Please Selecte this Box");
            combo.Focus();
            return false;
        }

        public static bool validatePrice(TextBox text)
        {
            if (text.Text.Trim() == "" || Convert.ToInt32(text.Text.Trim()) <= 0)
            {
                MessageBox.Show("Price Cant be Zero ! want to sell it for free?");
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool validateNonZero(NumericUpDown number)
        {
            if (number.Value == 0)
            {
                MessageBox.Show("there should be atleast one of these in the house , right?");
                number.Focus();
                return false;
            }
            return true;
        }

    }
}
