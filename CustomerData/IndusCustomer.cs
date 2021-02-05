using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Derived class from Customer for an industrial customer type.
 * Contains constructors for new customer objects as well as methods.
 * Refers to base Customer class for calculating methods, and uses overloaded method.
 * Created on: 12-19-2020 (MM-DD-YYYY)
 * Last modified: 01-08-2021
 */
namespace CustomerData
{
    public class IndusCustomer : Customer
    {    /*DECLARATION OF CONSTANTS. 
         * Rates represent dollar values, while limits represent kWh values.
         */

        //For peak hours.
        private const double FIXEDINDUSPEAK = 76.00; //Fixed rate
        private const double RATEINDUSPEAK = 0.065; //Metered rate
        private const int LIMITINDUSPEAK = 1000; //Fixed rate usage limit
        //For off-peak hours.
        private const double FIXEDINDUSOFF = 40.00; //Fixed rate
        private const double RATEINDUSOFF = 0.028; //Metered rate
        private const int LIMITINDUSOFF = 1000; //Fixed rate usage limit
       
        /* END OF CONSTANT DECLARATIONS.*/

        private int usage; //Int to store the customer's usage
        private int offUsage; //Int to store the customer's off-peak usage

        //Constructor for residential customer. Introduces a new int, usage.
        public IndusCustomer(String cusName, int accNo, char cusType, int usage, int offUsage) : base(cusName, accNo, cusType)
        {
            this.usage = usage; //Setting peak hours usage.
            this.offUsage = offUsage; //Setting off-peak hours usage.
        }

        //Method for calculating the total power bill. Arguments can be overridden if the user wants to enter specific calculation parameters.
        public override void CalculateCharge(double ratePeak=RATEINDUSPEAK, int limitPeak=LIMITINDUSPEAK, double flatRatePeak=FIXEDINDUSPEAK, double rateOff = RATEINDUSOFF, int limitOff = LIMITINDUSOFF, double flatRateOff = FIXEDINDUSOFF)
        {
            double peakCost = GetCost(usage, ratePeak, limitPeak, flatRatePeak); //Calculating peak hours bill.
            double offCost = GetCost(offUsage, rateOff, limitOff, flatRateOff); //Calculating off-peak hours bill
            chargeAmount = peakCost + offCost; //Stores the sum of both peak and off-peak bills.
        }
    }
}
