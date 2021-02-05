using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Derived class from Customer for a residential customer type.
 * Contains constructors for new customer objects as well as methods.
 * Refers to base Customer class for calculating methods.
 * Created on: 12-19-2020 (MM-DD-YYYY)
 * Last modified: 01-08-2021
 */
namespace CustomerData
{
    public class ResCustomer: Customer
    {    /*DECLARATION OF CONSTANTS. 
         * Rates represent dollar values, while limits represent kWh values.
         */
        private const double FIXEDRES = 6.00; //Fixed rate
        private const double RATERES = 0.052; //Metered rate
        private const int LIMITRES = 0; //Fixed rate usage limit. Current 0, but added to allow future changes.
        /* END OF CONSTANT DECLARATIONS.*/
        
        private int usage;//Int to store the customer's usage

        //Constructor for residential customer. Introduces a new int, usage.
        public ResCustomer(String cusName, int accNo, char cusType, int usage): base(cusName, accNo, cusType) 
        {
            this.usage = usage;
        }

        //Method for calculating the total power bill. Arguments can be overridden if the user wants to enter specific calculation parameters.
        public override void CalculateCharge(double rate=RATERES, int limit=LIMITRES, double flatRate=FIXEDRES)
        {
            chargeAmount = GetCost(usage, rate, limit, flatRate);
        }
    }
}
