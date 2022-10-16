using AssignmentClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClient
{
    internal class Program
    {
        const string WRONG_INPUT_MESSAGE = "Wrong input. Enter value between 1 and 6...",
            MENU_OPTION_PRIME_NUMBER = "1. Prime number",
            MENU_OPTION_SUM_DIGITS = "2. Sum of digits",
            MENU_OPTION_REVERSE_STRING = "3. Reverse a string",
            MENU_OPTION_HTML_TAGS = "4. Print HTML tags",
            MENU_OPTION_SORT_5_NUMBERS = "5. Sort 5 numbers",
            MENU_OPTION_EXIT = "6. Exit",
            MENU_ENTER_CHOICE ="\n Enter your choice:",
            ASSIGNMENT_TITLE = "Dmytrii Furs (#8703133) - Assignment 1",

            PRIME_NUMBER_MESSAGE = "Please enter number:",
            PRIME_NUMBER_RESULT = "Result is: ",
            SUM_NUMBER_MESSAGE = "Please enter number:",
            SUM_NUMBER_RESULT = "Result is: ";

        static void Main(string[] args)
        {
            ServiceReference1.AssignmentService1Client client = new ServiceReference1.AssignmentService1Client();

            string choice = "";

            Console.WriteLine(ASSIGNMENT_TITLE);
            Console.WriteLine();

            while(true)
            {
                ShowMenu();
                choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                            PrimeNumbers(client);
                            break;

                    case "2":
                            SumOfDigits(client);    
                            break;
                    case "3":
                        
                            break;
                    case "4":
                        
                            break;
                    case "5":
                        
                            break;
                    case "6":

                        return;
                    default:
                        Console.WriteLine(WRONG_INPUT_MESSAGE);
                        break;
                }

            }

        }

        public static void ShowMenu()
        {
            Console.WriteLine(MENU_OPTION_PRIME_NUMBER);
            Console.WriteLine(MENU_OPTION_SUM_DIGITS);
            Console.WriteLine(MENU_OPTION_REVERSE_STRING);
            Console.WriteLine(MENU_OPTION_HTML_TAGS);
            Console.WriteLine(MENU_OPTION_SORT_5_NUMBERS);
            Console.WriteLine(MENU_OPTION_EXIT);
            Console.WriteLine(MENU_ENTER_CHOICE);
        }

        public static void PrimeNumbers(AssignmentService1Client client)
        {
           
            int inputNumber = 0;
            string result = "";

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine(PRIME_NUMBER_MESSAGE);
                    inputNumber = Convert.ToInt32(Console.ReadLine());

                    result = client.PrimeNumber(inputNumber);

                    Console.WriteLine();
                    Console.WriteLine(PRIME_NUMBER_RESULT + result);
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error is: " + ex.Message);
                }
            }
           
        }

        public static void SumOfDigits(AssignmentService1Client client)
        {

            int inputNumber = 0;
            int result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine(SUM_NUMBER_MESSAGE);
                    inputNumber = Convert.ToInt32(Console.ReadLine());

                    result = client.Sum(inputNumber);

                    Console.WriteLine();
                    Console.WriteLine(SUM_NUMBER_RESULT + result);
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error is: " + ex.Message);
                }
            }

        }
    }
}
