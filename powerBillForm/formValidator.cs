using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace powerBillForm
{/*Repository of validation methods for user data entry.
  * Integrated into: powerBillCalculator
  * Author: Tony (Zongzheng Li) Li
  * Created on: 12-16-2020 (DD-MM-YYYY)
  * Last modified on: 12-17-2020
  */
    class formValidator
    {
        //Method to test whether or not a field is a number and greater than 0.
        public static bool IsNumber(TextBox field, string label)
        {
            bool isValid  = true; //The user's entry is assumed to be valid first.
            double input; //Variable used to store the user's input
            try //Tries to convert the text in the specified field to an integer. If it cannot, throw an error.
            {
                input = Convert.ToInt32(field.Text);
                if (input < 0)
                {
                    MessageBox.Show(label + " must be 0 or a positive number.", "Error - Non-positive Value");
                    field.SelectAll(); //Highlights all content in the field to make edits easier.
                    field.Focus(); //Focuses field to indicate the field that is wrong.
                    isValid = false;
                }
            }
            catch (FormatException)
            //Gives the user an error message, so that they know they must enter a whole number.
            {
                MessageBox.Show(label + " must be a whole number.", "Error - Invalid Input");
                field.SelectAll();
                field.Focus();
                isValid = false;
            }

            return isValid;
        }
        //Method to check if a field is empty or not.
        public static bool IsNotEmpty(TextBox field, string label)
        {
            bool isValid = true; //The user's entry is assumed to be valid first.
            
            if (field.Text == "")
            //If the field is empty, then an error message is returned to the user.
            {
                MessageBox.Show(label + " cannot be empty.", "Error - Empty Value");
                field.SelectAll();
                field.Focus();
                isValid = false;
            }

            return isValid;
        }
    }
}
