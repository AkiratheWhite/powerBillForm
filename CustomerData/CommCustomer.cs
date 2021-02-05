using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Derived class from Customer for a commercial customer type.
 * Contains constructors for new customer objects as well as methods.
 * Refers to base Customer class for calculating methods.
 * Created on: 12-19-2020 (MM-DD-YYYY)
 * Last modified: 01-08-2021
 */
namespace CustomerData
{
    public class CommCustomer : Customer
    {    /*DECLARATION OF CONSTANTS. 
         * Rates represent dollar values, while limits represent kWh values.
         */
        private const double FIXEDCOMM = 60.00; //Fixed rate
        private const double RATECOMM = 0.045; //Metered rate
        private const int LIMITCOMM = 1000; //Fixed rate usage limit
        /* END OF CONSTANT DECLARATIONS.*/

        private int usage;//Int to store the customer's usage

        //Constructor for residential customer. Introduces a new int, usage.
        public CommCustomer(String cusName, int accNo, char cusType, int usage) : base(cusName, accNo, cusType)
        {
            this.usage = usage;
        }

        //Method for calculating the total power bill. Arguments can be overridden if the user wants to enter specific calculation parameters.
        public override void CalculateCharge(double rate=RATECOMM, int limit=LIMITCOMM, double flatRate=FIXEDCOMM)
        {
            chargeAmount = GetCost(usage, rate, limit, flatRate);
        }
    }
}
