using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace powerBillForm
{/*Methods used for writing to and reading from the Customers.txt file.
  * Includes two methods: recordCustomer (for writing to the .txt file) and readCustomers (for reading from the .txt file)
  * Author: Tony (Zongzheng) Li
  * Created on: 12-21-2020 (MM-DD-YYYY)
  * Last modified: 01-08-2021
  */
	class ReadWrite
    {	
		//Method for writing to the Customers.txt file.
		public static void recordCustomer (String args)
		{
			string filePath = "Customers.txt"; //Declares a string for the file path.

			//The .txt file will be created if it doesn't exist, and updated if it does exist.
			using (StreamWriter sr = File.AppendText(filePath))
            {
				sr.WriteLine(args);//Writes the string provided as an argument to the Customers.txt file.
			}
		}
		
		//Method for reading entries from the Customers.txt file.
		public static List<string[]> readCustomers () 
        {
			List<string[]> entries = new List<string[]>(); //Declares a list for String arrays. This will be used to story entries.

			string filePath = "Customers.txt"; //Declares a string for the file path.
			string line; //Declares a string that will be used for iteration.

			try //Try block to catch errors. If the file does not exist, it should be created.
			{
			//Declares a new file stream for the file path, with open/create mode, and read access.
			FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);


				//While there are lines in the Customers.txt file, the while loop will run.
				while ((line = sr.ReadLine()) != null)
				{
					/*Using '|' as a delimiter, each line in the .txt file is split and put into a string array.
					 *The array created from the Split method is then added to the string array list. */
					entries.Add(line.Split('|'));
				}
				sr.Close(); //The file is closed once the while loop ends.
				return entries; //The string array is returned, where the form will use a method to add all the values to a dataGridView.
			}

			catch //Returns a null string array list if an error does occur.
            {
				return null;
            }
		}
	}
}
