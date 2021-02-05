using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData;
using System.Windows.Forms;

namespace powerBillForm
{   /*The purpose of this application is to calculate a customer bill for a hypothetical city power company.
     * Calculations are done for one customer at a time based on their power usage in kWh.
     * Rates are specified for the following customer types: residential, commerical, and industrial.
     * Created on: 12-15-2020 (MM-DD-YYYY)
     * Author: Tony (Zongzheng) Li
     * Last modified: 01-08-2021
    */
    public partial class powerBillForm : Form
    {
        /*DECLARATION OF CONSTANTS. 
         * Rates represent dollar values, while limits represent kWh values.
         */

        //For residential customers.
        public const double FIXEDRES = 6.00; //Fixed rate
        public const double RATERES = 0.052; //Metered rate
        public const int LIMITRES = 0; //Fixed rate usage limit. Current 0, but added to allow future changes.
        //For commercial customers.
        public const double FIXEDCOMM = 60.00; //Fixed rate
        public const double RATECOMM = 0.045; //Metered rate
        public const int LIMITCOMM = 1000; //Fixed rate usage limit

        //Declaration for industrial customers, separated by peak-hours and off-peak hours.
        //For peak hours.
        public const double FIXEDINDUSPEAK = 76.00; //Fixed rate
        public const double RATEINDUSPEAK = 0.065; //Metered rate
        public const int LIMITINDUSPEAK = 1000; //Fixed rate usage limit
        //For off-peak hours.
        public const double FIXEDINDUSOFF = 40.00; //Fixed rate
        public const double RATEINDUSOFF = 0.028; //Metered rate
        public const int LIMITINDUSOFF = 1000; //Fixed rate usage limit

        /* END OF CONSTANT DECLARATIONS.*/
        
        //List of customer objects to store information being read from Customer.txt.
        public List<Customer> currentCus = new List<Customer>();

        public powerBillForm()
        {
            InitializeComponent();
        }

        //Method for calculating total bill on click of the "Calculate" button.
        private void BtnCalculateCost_Click(object sender, EventArgs e)
        {
            if (formValidator.IsNotEmpty(txtUsage, "Power usage") && formValidator.IsNumber(txtUsage, "Power usage") && formValidator.IsNotEmpty(txtCusName, "Customer Name") && formValidator.IsNotEmpty(txtAccNo, "Account No."))
            {
                //Declares a variable to store user inputs.
                String cusName = txtCusName.Text;
                int accNo = Convert.ToInt32(txtAccNo.Text);
                int userUsage = Convert.ToInt32(txtUsage.Text);
                int offUsage;
                //Switch to handle form response depending on customer type.
                switch (comboCusType.SelectedItem)
                {
                    case "Residential":
                        ResCustomer testCusR = new ResCustomer(cusName, accNo, 'R', userUsage) ; //Declares a dummy customer to use for the form.
                        ResResp(testCusR);
                        break;
                    case "Commercial":
                        CommCustomer testCusC = new CommCustomer(cusName, accNo, 'C', userUsage); //Declares a dummy customer to use for the form.
                        CommResp(testCusC, userUsage);
                        break;
                    case "Industrial":
                        if (formValidator.IsNotEmpty(txtUsageOff, "Power usage") && formValidator.IsNumber(txtUsageOff, "Power usage")) {
                            offUsage = Convert.ToInt32(txtUsageOff.Text);
                            IndusCustomer testCusI = new IndusCustomer(cusName, accNo, 'I', userUsage, offUsage);
                            IndusResp(testCusI, userUsage, offUsage);
                        }
                        break;
                }
            }
            //Updates the statistics regarding the customers.
            calcStats(currentCus);
        }

        //If a customer is residential, use the specified residential rates.
        private void ResResp(ResCustomer args)
        {
            //Populates the form with extra details and the total bill.
            txtFlatRate.Text = FIXEDRES.ToString("c");
            txtFlatRateLimit.Text = LIMITRES.ToString("n");

            txtUsageRate.Text = RATERES.ToString("c4");
            txtOverLimit.Text = "N/A"; //There is no limit currently specified for residential users.

            //Use the calculateCharge method and ToString method to return metered cost.
            args.CalculateCharge();
            txtTotalCost.Text = args.ToString(); //Shows the user their total bill.

            //Write customer data to a local .txt file.
            String cusData = $"{args.CusName}|{args.AccNo}|{args.CusType}|{args.ToString()}";
            ReadWrite.recordCustomer(cusData);
            /*Adds the new customer's data to the dataGridView.
             * Makes it so that the dataGridView does not need to be reinitialized every time.*/
            addToDataGrid(args.CusName, args.AccNo, args.CusType, args.ToString());
            //Adds the new customer to the list of Customer objects being accessed by the form.
            currentCus.Add(args);
        }

        //If a customer is commercial, use the specified commercial rates.
        private void CommResp(CommCustomer args, int userUsage)
        {
            //Populates the form with extra details and the total bill.
            txtFlatRate.Text = FIXEDCOMM.ToString("c");
            txtFlatRateLimit.Text = LIMITCOMM.ToString("n");

            txtUsageRate.Text = RATECOMM.ToString("c4");
            if ((userUsage - LIMITCOMM) > 0 )
            {
                txtOverLimit.Text = (userUsage - LIMITCOMM).ToString("n");
            }
            else
            {
                txtOverLimit.Text = "N/A";
            }
            
            //Use the calculateCharge method and ToString method to return metered cost.
            args.CalculateCharge();
            txtTotalCost.Text = args.ToString(); //Shows the user their total bill.

            //Write customer data to a local .txt file.
            String cusData = $"{args.CusName}|{args.AccNo}|{args.CusType}|{args.ToString()}";
            ReadWrite.recordCustomer(cusData);
            
            /*Adds the new customer's data to the dataGridView.
             * Makes it so that the dataGridView does not need to be reinitialized every time.*/
            addToDataGrid(args.CusName, args.AccNo, args.CusType, args.ToString());
            //Adds the new customer to the list of Customer objects being accessed by the form.
            currentCus.Add(args);
        }
        private void IndusResp(IndusCustomer args, int userUsage, int offUsage)
        {
            //Populates the form with extra details and the total bill.
            txtFlatRate.Text = FIXEDINDUSPEAK.ToString("c");
            txtFlatRateLimit.Text = LIMITINDUSPEAK.ToString("n");
            txtUsageRate.Text = RATEINDUSPEAK.ToString("c4");

            //Checks to see if the customer has used more than their metered limit for peak hours. Same algorithm/logic as commerical case.
            if ((userUsage - LIMITINDUSPEAK) > 0)
            {
                txtOverLimit.Text = (userUsage - LIMITINDUSPEAK).ToString("n");
            }
            else
            {
                txtOverLimit.Text = "N/A";
                txtUsageCost.Text = "N/A";
            }

            txtFlatRateOff.Text = FIXEDINDUSOFF.ToString("c");
            txtFlatRateLimitOff.Text = LIMITINDUSOFF.ToString("n");
            txtUsageRateOff.Text = RATEINDUSOFF.ToString("c4");

            //Repeats the above method for the off-peak hours.
            if ((offUsage - LIMITINDUSOFF) > 0)
            {
                txtOverLimitOff.Text = (offUsage - LIMITINDUSOFF).ToString("n");
            }
            else
            {
                txtOverLimitOff.Text = "N/A";
                txtUsageCostOff.Text = "N/A";
            }
            //Use the calculateCharge method and ToString method to return metered cost.
            args.CalculateCharge();
            txtTotalCost.Text = args.ToString(); //Shows the user their total bill.

            //Write customer data to a local .txt file.
            String cusData = $"{args.CusName}|{args.AccNo}|{args.CusType}|{args.ToString()}";
            ReadWrite.recordCustomer(cusData);
            /*Adds the new customer's data to the dataGridView.
             * Makes it so that the dataGridView does not need to be reinitialized every time.*/
            addToDataGrid(args.CusName, args.AccNo, args.CusType, args.ToString());
            //Adds the new customer to the list of Customer objects being accessed by the form.
            currentCus.Add(args);
        }

        //Sets focus to "Power Usage" field upon form load, and defaults customer type to "Residential"
        private void PowerBillForm_Load(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
            PowerCalcTab.BackColor = Color.FromArgb(241, 169, 160);
            comboCusType.SelectedItem = "Residential";
            initializeCusData();
            this.ActiveControl = txtUsage;
        }
        //Resets all fields to empty and puts the focus back on the "Customer Name" field.
        //Details panel is hidden, and customer type is sent back to residential.
        private void BtnReset_Click(object sender, EventArgs e)
        {
            comboCusType.SelectedItem = "Residential";
            chkDetails.Checked = false;

            txtUsage.Text = "";
            txtFlatRate.Text = "";
            txtFlatRateLimit.Text = "";
            txtOverLimit.Text = "";
            txtUsageRate.Text = "";
            txtUsageCost.Text = "";

            txtUsageOff.Text = "";
            txtFlatRateOff.Text = "";
            txtFlatRateLimitOff.Text = "";
            txtOverLimitOff.Text = "";
            txtUsageRateOff.Text = "";
            txtUsageCostOff.Text = "";

            txtTotalCost.Text = "";

            txtCusName.Text = "";
            txtAccNo.Text = "";

            txtCusName.Focus();
        }

        /*If the user changes their customer type after already entering information, 
         * reset all fields and set focus to "Power Usage" field. 
         * Also hides irrelevant fields for specified customer type.*/
        private void ComboCusType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFlatRate.Text = "";
            txtFlatRateLimit.Text = "";
            txtOverLimit.Text = "";
            txtUsageRate.Text = "";
            txtUsageCost.Text = "";

            txtUsageOff.Text = "";
            txtFlatRateOff.Text = "";
            txtFlatRateLimitOff.Text = "";
            txtOverLimitOff.Text = "";
            txtUsageRateOff.Text = "";
            txtUsageCostOff.Text = "";

            txtTotalCost.Text = "";
            //Depending on the customer type selected, hide or alter text.
            //Only industrial customers need to see the peak/off-peak fields.
            switch (comboCusType.SelectedItem)
            {
                case "Residential":
                    PowerCalcTab.BackColor = Color.FromArgb(241, 169, 160); 
                    lblPowerUse.Text = "Power Usage (kWh)";
                    lblPeak.Text = "Usage";
                    lblPowerUseOff.Visible = false;
                    txtUsageOff.Visible = false;
                    lblOff.Visible = false;
                    panelOff.Visible = false;
                    break;
                case "Commercial":
                    PowerCalcTab.BackColor = Color.FromArgb(244, 247, 118);
                    lblPowerUse.Text = "Power Usage (kWh)";
                    lblPeak.Text = "Usage";
                    lblPowerUseOff.Visible = false;
                    txtUsageOff.Visible = false;
                    lblOff.Visible = false;
                    panelOff.Visible = false;
                    break;
                case "Industrial":
                    //Off-peak fields become visible.
                    PowerCalcTab.BackColor = Color.FromArgb(137, 196, 244);
                    lblPowerUse.Text = "Power Usage (Peak, kWh)";
                    lblPeak.Text = "Peak Usage";
                    lblPowerUseOff.Visible = true;
                    txtUsageOff.Visible = true;
                    lblOff.Visible = true;
                    panelOff.Visible = true;
                    break;
            }
            //Focus set to "Power Usage" field.
            txtUsage.Focus();
        }
        //Closes application when clicking exit button.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //If the checkbox is clicked, it is either switched to a checked or unchecked status.
        private void ChkDetails_Click(object sender, EventArgs e)
        {
            if (chkDetails.Checked == true)
            {
                chkDetails.Checked = false;
            }

            else
            {
                chkDetails.Checked = true;
            }
        }
        //If the checkbox is checked, extra details become visible. Unchecking the box hides the details again.
        private void ChkDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDetails.Checked == true)
            {
                panelDetails.Visible = true;
            }

            else
            {
                panelDetails.Visible = false;
            }
        }

        //Method for reading data from the Customer.txt file. Will only execute on form load.
        private void initializeCusData ()
        {
            /*Removes all current entries from the dataGridView. This prevents duplication of already existing entries when adding a new customer.*/
            this.dataCusData.Rows.Clear();

            try { 
                List<string[]> cusData = ReadWrite.readCustomers(); //Tries to read all lines from the Customers.txt file.
                /*For each item in the string array list, add a new row with entries for each column.*/
                foreach (string[] item in cusData) 
                {
                    //Initializes a new customer object, and passes strings read from Customer.txt to it as arguments.
                    Customer tempCus = new Customer(item[0], Convert.ToInt32(item[1]), Convert.ToChar(item[2]));
                    //Sets the charged amount to the proper value. Charged amount is not a valid argument for the constructor.
                    tempCus.ChargedAmount = Convert.ToDouble(item[3].Trim('$'));

                    //Adds the tempCus Customer object to the currentCus Customer object list.
                    currentCus.Add(tempCus);

                    //Since the string data has already been read, it is more efficient to populate the dataGridView now than to read the properties from the customer object.
                    this.dataCusData.Rows.Add(item[0], item[1], item[2], item[3]);
                }

                calcStats(currentCus);
            }
            catch (NullReferenceException) //If the string array list cusData is null, do not run the function.
            {
                MessageBox.Show("Customer.txt cannot be found.");
            }
        }

        //Method to update the dataGridView with new customer data. This way, the dataGridView's data does not need to be reset whenever it is updated.
        private void addToDataGrid (string cusName, int accNo, char cusType, string chargeAmount)
        {
            this.dataCusData.Rows.Add(cusName, accNo, cusType, chargeAmount);
        }
        
        //Method to compute the statistics of all customers. Takes the currentCus Customer object list as an argument.
        private void calcStats(List<Customer> args)
        {
            int cusCount=args.Count(); //Counts the number of items in the currentCus list.
            //Declares values for residential, commercial, industrial, and total charges.
            double resCharge= 0, commCharge=0, indusCharge=0, totalCharge=0;

            //For loop to iterate over all items in the currentCus list.
            foreach (Customer entry in args)
            {
                //If the customer type is residential, add their charge to the residential charge total.
                if (entry.CusType == 'R')
                {
                    resCharge += entry.ChargedAmount;
                }

                //If the customer type is commercial, add their charge to the commercial charge total.
                if (entry.CusType == 'C')
                {
                    commCharge += entry.ChargedAmount;
                }

                //if the customer type is industrial, add their charge to the industrial charge total. 
                if (entry.CusType == 'I')
                {
                    indusCharge += entry.ChargedAmount;
                }

                //Regardless of the customer type, add their charge to the total charge for all customers.
                totalCharge += entry.ChargedAmount;
            }

            //Set all releveant textboxs in the form to their appropriate value in currency.
            txtCusCount.Text = cusCount.ToString();
            txtResCharge.Text = resCharge.ToString("c2");
            txtCommCharge.Text = commCharge.ToString("c2");
            txtIndusCharge.Text = indusCharge.ToString("c2");
            txtTotalCharge.Text = totalCharge.ToString("c2");
        }
    }
}
