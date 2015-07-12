using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace IncomeTaxCalculator
namespace IncomeTaxCalculator
{
    /// <summary> 
    /// This program will calculate the income tax according to the given formula. 
    /// </summary>
        
    //start class program
    class Program
    {
        //start main method
        static void Main(string[] args)
        {
            //declare variables
            double income = 0.0;
            double tax = 0.0;
            double incomeDif = 0.0;                        
            double calcDif = 0.0;
            bool isNum = false;
            String userChoice = String.Empty;
            
            //Greeting line followed by the prompt to enter income
            Console.WriteLine("Welcome To The Income Tax Calculation Program" + "\n");

            //Using do/while loop
            do
            {
                //Prompt user to enter income
                Console.WriteLine("Please enter your income: ");                
            
                //using TryParse to check if the input is a number
                isNum = double.TryParse(Console.ReadLine(), out income);

                //if the input is not a number system will print out the following message
                if (income < 0)
                {
                    Console.WriteLine("Invalid input");
                }
                // if/else loop to find out the income tax according to the given value
                else if (income <= 20000)
                {
                    tax = income * .05;
                }
                else if (income > 20000 && income <= 50000)
                {
                    incomeDif = income - 20000;
                    calcDif = incomeDif * .1;
                    tax = calcDif + 1000;
                }
                else if (income > 50000 && income <= 75000)
                {
                    incomeDif = income - 50000;
                    calcDif = incomeDif * .2;
                    tax = calcDif + 4000;
                }
                else
                {
                    incomeDif = income - 75000;
                    calcDif = incomeDif * .35;
                    tax = calcDif + 9000;
                }
                //Print out the calculated income tax
                Console.WriteLine("Calculated InCome Tax: " + tax);
                Console.WriteLine();

                //Using do/while loop to ask user if the user want to continue
                do
                {
                    //Prompt if user want to continue
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    userChoice = Console.ReadLine().ToUpper();
                    //Check if the user entered yes or no
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, please say Yes or No");
                    }
                }while (userChoice != "YES" && userChoice != "NO");                
            }while (userChoice == "YES");

        }//end main method
    }//end class Program
}//end namespace IncomeTaxCalculator