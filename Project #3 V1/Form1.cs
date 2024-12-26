/*
 * ICT 710 - Computer Programming I 
 * Project 3: Methods, Data Validation and Arrays
 * By: Brandon Collette
 * Calgary, Alberta
 * December, 2024
 * The project is intended to accomplish the following:
 * 1. Create a Windows Forms app that will allow a individual employee to enter their name, hours worked and hourly pay
 * 2. Calculate, from the information above the individuals pay (including overtime pay at a modified rate)
 * 3. Send to a listbox each employees name and total pay
 * 4. Aggregrate both total payroll for all employees and the number of employees who have entered payroll information
 * 5. Validate all entry data to prevent accidental entry of incorrect information or information that cannot be processed  
 */

namespace Project__3_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX_SIZE = 20; // establish a constant to prevent more than 20 entries being entered. 
        const decimal standardHours = 37.5m; // declaring a constant to establish hours worked before overtime threshold is reached. Will be used in calculations belwo
        decimal TotalIndivPay = 0; // declaring a variable of type decimal to store individual instances of payroll totals for one person 
        decimal totalCumulativePay = 0; // declaring a variable of type decimal to store accumulated payroll amounts
        string[] employeeNames = new string[MAX_SIZE]; // Declaring an array to store the employee names. Type String to work with characters instead of numbers etc
        decimal[] individualPay = new decimal[MAX_SIZE]; // Declaring an array to store invididual pay associated with a employee
        decimal[] cumulativePay = new decimal[MAX_SIZE]; // creating an array of type decimal that will store cumulative employees pay into a array
        int employeeCount = 0; // delaring a variance of type int to keep track of how many employees have been added 
        int currentIndex = 0; // see below
        /*
         * The above currentIndex declaration is required to establish a situation where individual instances of payroll entry
         * will increment into the array i.e. payroll calculation CumulativePay #1 will go to currentIndex 0 and then
         * CumulativePay #2 will go into currentIndex 1 etc etc 
         * Needs to start at zero as this is the first possible position in a array in the C# format
         * 
         */

        private ListBox listboxEmployees; // LOOK INTO THIS

        private void btnAddToPayroll_Click(object sender, EventArgs e)
        {
            /*
               * The below are a series of data entry validators. Please note the following:
               * 1. The validators themselves are coming from a seperate class we have created within this project called "Validator.cs"
               * 2. They all serve to ensure that the employee name, hours worked and hourly rate will prevent the entry of:
               *      A. Blank information
               *      B. Negative numbers being entered 
               *      C. Instances of 0 being entered (not possible to work zero hours and have a payroll calculation)
               */
            if
            (
                Validator.IsPresent(txtEmployeeName)
                &&
                Validator.ContainsOnlyLetters(txtEmployeeName)
                &&
                Validator.IsPresent(txtHoursWorked)
                &&
                Validator.IsPresent(txtHourlyRate)
                &&
                Validator.IsNonNegativeDecimal(txtHoursWorked) 
                &&
                Validator.IsNonNegativeDecimal(txtHourlyRate)
                &&
                Validator.IsNonZero(txtHoursWorked)
                &&
                Validator.IsNonZero(txtHourlyRate)
            )
            {
                /*
                 * The below code is the "core" payroll calculation and functions as follows: 
                 * 1. Retrieve from the appropriate text box a employees hours worked and hourly pay (note: No need to consider name input at this point)
                 * 2. Calculate regular hours pay as the pay per hour up to 37.5 hours 
                 * 3. Calculate overtimep pay as the hours worked above 37.5 hours (if applicable) and at a rate of 1.5x
                 * 4. Store the total invidual pay to a dedicated variable
                 * 5. Flush the result of individual pay to the appropriate text box
                 */
                decimal HoursWorked = Convert.ToDecimal(txtHoursWorked.Text); // "fetches" the user input of hours worked from the textbox HoursWorked and converts to int format
                decimal HourlyRate = Convert.ToDecimal(txtHourlyRate.Text);
                if (HoursWorked <= standardHours)
                {
                    TotalIndivPay = HoursWorked * HourlyRate;
                    txtEmployeePay.Text = TotalIndivPay.ToString("C");
                }
                else if (HoursWorked > standardHours) // I changed this from else to else if
                {
                    decimal OTRate = HourlyRate * 1.5m;
                    TotalIndivPay = (standardHours * HourlyRate) + ((HoursWorked - standardHours) * OTRate);
                    txtEmployeePay.Text = TotalIndivPay.ToString("C");
                }
                /*
                 * The below code manages the "CumulativePay" array and the accumulation of invidual pay amounts and functions as follows:
                 * 1. Sets the input to the cumulativepay array to add the above calculations of individual pay
                 * 2. Increments the array to allow for the next instances of individual pay to be added
                 * 3. Defines totalCumulativePay to be the sum of the above
                 * 4. Sends the accumulated results to the appropriate textbox
                 * Important to note below that .Length is a standard C# property which returns the total number of elements in a array 
                 */

                if (currentIndex < cumulativePay.Length) // Since current index was set to 0 above, this code functions to determine if anything has been entered at all
                {
                    cumulativePay[currentIndex] = TotalIndivPay; // Sets the input to the cumulativepay array to add the above calculations of individual pay
                    currentIndex++; //Increments the array to allow for the next instances of individual pay to be added
                    decimal totalCumulativePay = cumulativePay.Sum(); // Defines totalCumulativePay to be the sum of the above individual pay that makes it way into the array
                    txtPayrollTotal.Text = totalCumulativePay.ToString("C"); // Sending cumulative pay to the appropriate text box
                }

                /*
                 * The below code is the "core" array management code and functions as follows:
                 * 1. Defines that the array employeeNames should add the input from the EmployeeName Text box
                 * 2. Declares a new string called employeeInfo that will contain both employee names from above and cumulativePay from the above method
                 * 3. "flushes" the above string containing the employee data to the respective text box
                 * 4. Incremements the array that stores the number of individual employees 
                 * 5. Sends the above incremented value to the appropriate text box
                 */

                employeeNames[employeeCount] = txtEmployeeName.Text; // "fetches" the currently entered employee name and stores to array
                string employeeInfo = employeeNames[employeeCount] + " - $" + cumulativePay[employeeCount].ToString("N2");
                lstPayrollSum.Items.Add(employeeInfo);
                employeeCount++; // Serves to increment the # of employees each time a new entry is made 
                txtNumberEmployees.Text = employeeCount.ToString("D"); // Sends the total number of employees to the appropriate textbox

                // The below will clear the respective data entry texy boxes to permit the entry of new data
                txtHoursWorked.Clear();
                txtHourlyRate.Clear();
                txtEmployeeName.Clear();
            }
        }
        // The below will terminate the application when the exit button is pressed 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // The below will serve to clear the individual employee pay shown in the textbox to faciliate the display of the next employees pay
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeePay.Clear();
        }
    }
}
