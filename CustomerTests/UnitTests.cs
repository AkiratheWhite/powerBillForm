using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerData;

namespace CustomerTests
{
    [TestClass]
    public class CustomerTests
    {   /* START OF TEST METHODS FOR RESIDENTIAL CUSTOMERS */
        //Method to test if residential customer class calculates properly on a usage of 0 kWh.
        [TestMethod]
        public void ResCustomerWith0()
        {
            //Arrange
            //Set up all parameters to initalize a new residential customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'R';
            int usage = 0;
            ResCustomer testCustomer = new ResCustomer(name, accNo, cusType, usage);
            string expectedCharge = "$6.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        
        //Method to test if residential customer class calculates properly on a usage of 50 kWh.
        [TestMethod]
        public void ResCustomerWith50()
        {
            //Arrange
            //Set up all parameters to initalize a new residential customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'R';
            int usage = 50;
            ResCustomer testCustomer = new ResCustomer(name, accNo, cusType, usage);
            string expectedCharge = "$8.60"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        /* END OF TEST METHODS FOR RESIDENTIAL CUSTOMERS */

        /* START OF TEST METHODS FOR COMMERCIAL CUSTOMERS */
        //Method to test if commercial customer class calculates properly on a usage of 0 kWh.
        [TestMethod]
        public void CommCustomerWith0()
        {
            //Arrange
            //Set up all parameters to initalize a new commerical customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'C';
            int usage = 0;
            CommCustomer testCustomer = new CommCustomer(name, accNo, cusType, usage);
            string expectedCharge = "$60.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //Method to test if commercial customer class calculates properly on a usage of 1000 kWh.
        [TestMethod]
        public void CommCustomerWith1000()
        {
            //Arrange
            //Set up all parameters to initalize a new commercial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'C';
            int usage = 1000;
            CommCustomer testCustomer = new CommCustomer(name, accNo, cusType, usage);
            string expectedCharge = "$60.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //Method to test if commercial customer class calculates properly on a usage of 1500 kWh.
        [TestMethod]
        public void CommCustomerWith1500()
        {
            //Arrange
            //Set up all parameters to initalize a new commercial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'C';
            int usage = 1500;
            CommCustomer testCustomer = new CommCustomer(name, accNo, cusType, usage);
            string expectedCharge = "$82.50"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //Method to test if commercial customer class calculates properly on a usage of 2000 kWh.
        [TestMethod]
        public void CommCustomerWith2000()
        {
            //Arrange
            //Set up all parameters to initalize a new commercial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'C';
            int usage = 2000;
            CommCustomer testCustomer = new CommCustomer(name, accNo, cusType, usage);
            string expectedCharge = "$105.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        /* END OF TEST METHODS FOR COMMERICAL CUSTOMERS */

        /* START OF TEST METHODS FOR INDUSTRIAL CUSTOMERS */
        //Method to test if industiral customer class calculates properly on a peak usage of 0 kWh and an off-peak usage of 0 kWh.
        [TestMethod]
        public void IndusCustomerWith0And0()
        {
            //Arrange
            //Set up all parameters to initalize a new industrial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'I';
            int usage = 0;
            int offUsage = 0;
            IndusCustomer testCustomer = new IndusCustomer(name, accNo, cusType, usage, offUsage);
            string expectedCharge = "$116.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        //Method to test if industiral customer class calculates properly on a peak usage of 1000 kWh and an off-peak usage of 1000 kWh.
        [TestMethod]
        public void IndusCustomerWith1000And1000()
        {
            //Arrange
            //Set up all parameters to initalize a new industrial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'I';
            int usage = 1000;
            int offUsage = 1000;
            IndusCustomer testCustomer = new IndusCustomer(name, accNo, cusType, usage, offUsage);
            string expectedCharge = "$116.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //Method to test if industiral customer class calculates properly on a peak usage of 1500 kWh and an off-peak usage of 1000 kWh.
        [TestMethod]
        public void IndusCustomerWith1500And1000()
        {
            //Arrange
            //Set up all parameters to initalize a new industrial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'I';
            int usage = 1500;
            int offUsage = 1000;
            IndusCustomer testCustomer = new IndusCustomer(name, accNo, cusType, usage, offUsage);
            string expectedCharge = "$148.50"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //Method to test if industiral customer class calculates properly on a peak usage of 1000 kWh and an off-peak usage of 1500 kWh.
        [TestMethod]
        public void IndusCustomerWith1000And1500()
        {
            //Arrange
            //Set up all parameters to initalize a new industrial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'I';
            int usage = 1000;
            int offUsage = 1500;
            IndusCustomer testCustomer = new IndusCustomer(name, accNo, cusType, usage, offUsage);
            string expectedCharge = "$130.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //Method to test if industiral customer class calculates properly on a peak usage of 2000 kWh and an off-peak usage of 2000 kWh.
        public void IndusCustomerWith2000And2000()
        {
            //Arrange
            //Set up all parameters to initalize a new industrial customer.
            String name = "Test";
            int accNo = 0;
            char cusType = 'I';
            int usage = 2000;
            int offUsage = 2000;
            IndusCustomer testCustomer = new IndusCustomer(name, accNo, cusType, usage, offUsage);
            string expectedCharge = "$209.00"; //Expected return value for CalculateCharge

            //Act
            testCustomer.CalculateCharge();

            //Assert
            string actualCharge = testCustomer.ToString();
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}
