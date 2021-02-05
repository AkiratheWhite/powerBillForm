using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Class Library for customer class and methods.
 * Contains constructors for new customer objects objects as well as methods.
 * Methods included can return the customer's bill.
 * Created on: 12-19-2020 (MM-DD-YYYY)
 * Last modified: 01-08-2021
 */
namespace CustomerData
{
    public class Customer
    {
        private int accNo; //Int to hold a positive integer for account number.
        private String cusName; //String to hold customer name. Cannot be empty.
        private char cusType; //Character to hold customer type.
        
        //Double to store the customer's charge amount. Made protected instead of private so that derived classes can access it.
        protected double chargeAmount;

        public Customer (String cusName, int accNo, char cusType, int usage=0, int offUsage=0) {//Constructor for Customer object.
            this.cusName = cusName;
            this.accNo = accNo;
            this.cusType = cusType;
        }

        //Method to access account number.
        public int AccNo
        {
            get
            {
                return accNo;
            }
        }

        //Method to access customer name.
        public String CusName
        {
            get
            {
                return cusName;
            }
        }

        //Method to access customer type.
        public char CusType
        {
            get
            {
                return cusType;
            }
        }

        public double ChargedAmount
        {
            get
            {
                return chargeAmount;
            }
            set
            {
                chargeAmount = value;
            }
        }

        //Virtual method that will be used to calculate the power bill for each customer type.
        public virtual void CalculateCharge(double rate, int limit, double flatRate)
        {

        }
        //Overloaded method that is identical to the one above. Used specifically for industrial customers.
        public virtual void CalculateCharge(double ratePeak, int limitPeak, double flatRatePeak, double rateOff, int limitOff, double flatRateOff)
        {

        }

        //Method for adding the metered and fixed cost of the customer based on their usage. Only accessible by customer objects.
        protected static double GetCost(int usage, double rate, int limit, double flatRate)
        {
            double meteredCost; //Variable to store the metered cost.
            double totalCost; //Variable to store the total bill calculated.

            //Use the calculateCost function to find metered cost.
            if ((usage - limit) > 0) //If their usage exceeds their limit, calculate a metered bill for the amount over the limit.
            {
                meteredCost = GetMetered(rate, (usage - limit));
            }

            else
            {
                meteredCost = 0; //If their usage does not exceed the limit, the metered bill is set to 0.
            }

            totalCost = meteredCost + flatRate;
            return totalCost;
        }

        //Method for calculating metered power bill based on inputted usage and rates. Only accessible by customer objects.
        protected static double GetMetered(double rate, int usage)
        {
            //Multiply the rate and the user usage together to get cost.
            double cost = rate * usage;
            return cost;
        }

        //Returns the customer's bill as a string in currency form.
        public override string ToString()
        {
            return chargeAmount.ToString("c2");
        }
    }
}
