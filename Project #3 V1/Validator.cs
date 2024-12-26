using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Project__3_V1 
{
    public static class Validator 
    {
        public static bool IsPresent(TextBox tb)  // will check if text box has something in it * see day 7 video at 2:13. See notes below
           
        {
            bool isValid = true;      // This is prearing someting to return" starting with true assumes everything is cool
            // Also the above is a standard variable declaration and setting the initial value to true
            if (String.IsNullOrEmpty(tb.Text))
            { 
                isValid = false;
                MessageBox.Show(tb.Tag + " is required");    
                tb.Focus(); // 
            }

            return isValid;  
        } // end of above method

        public static bool ContainsOnlyLetters(TextBox tb)

        {
            bool isValid = true;
            if (!String.IsNullOrEmpty(tb.Text)) // The exclamation mark here *reverses* the IF statement to only execute the below is something has been entered
            {
                foreach (char c in tb.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        isValid = false;
                        MessageBox.Show(tb.Tag + " Input for name should be letters only");
                        tb.Focus();
                        break;
                    }
                }
            }
            return isValid;
        }
        public static bool IsNonNegativeDecimal(TextBox tb) 
        {
            bool isValid = true;
            decimal result = 0;
            if (!Decimal.TryParse(tb.Text, out result)) // need to find out why she put exclamation mark
            {
                isValid |= false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.Focus();
            }
            else 
            {
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be a positive");
                    tb.Focus();
                }
            }
            return isValid;
        }
        public static bool IsNonZero(TextBox tb)
        {
            bool isValid = true;
            if (decimal.TryParse(tb.Text, out decimal value) && value == 0)
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " cannot be zero");
                tb.Focus();
            }
            return isValid;
        }

    } // class
} // name space

/*
 * 
 * Note to make the above work she turns on the "tag" property in the properties. See 2:13
 * I went to each text box and entered the title of the box into the "tag" field i.e. txtFeet tag = Feet etc
 * The above is like " a tool in your toolbox" and you need to "take it out" and actually use the tool i.e. we need some other 
 * code to be able to reference this "tool" 
 * 
 */