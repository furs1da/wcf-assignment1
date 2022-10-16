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
            SUM_NUMBER_RESULT = "Result is: ",
            
            REVERSE_STRING_MESSAGE = "Please enter number:",
            REVERSE_STRING_RESULT = "Result is: ",
            
            PRINT_HTML_TAG_MESSAGE = "Please enter tag:",
            PRINT_HTML_DATA_RESULT = "Please enter data:",
            PRINT_HTML_RESULT = "Result is: ",

            SORT5_MESSAGE = "Please enter number:",
            SORT5_RESULT = "Result is: ",
            SOTRING_TYPE_MESSAGE = "Please enter select sorting type (Enter 1 - for ascending sorting or Enter anything else for descending sorting): ";

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
                            ReverseString(client);
                            break;
                    case "4":
                            PrintHTMLTags(client);
                            break;
                    case "5":
                            Sort5(client);
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

        public static void ReverseString(AssignmentService1Client client)
        {
           Console.WriteLine();
           Console.WriteLine(REVERSE_STRING_MESSAGE);
           string result = Console.ReadLine();

           result = client.ReverseString(result);

           Console.WriteLine();
           Console.WriteLine(REVERSE_STRING_RESULT + result);
           Console.WriteLine();
           Console.WriteLine();        
        }

        public static void PrintHTMLTags(AssignmentService1Client client)
        {
            Console.WriteLine();
            Console.WriteLine(PRINT_HTML_TAG_MESSAGE);
            string tag = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(PRINT_HTML_DATA_RESULT);
            string data = Console.ReadLine();

            string result = "";

            result = client.PrintHTMLTag(tag, data);

            Console.WriteLine();
            Console.WriteLine(PRINT_HTML_RESULT + result);
            Console.WriteLine();
            Console.WriteLine();
        }


        public static void Sort5(AssignmentService1Client client)
        {
            List<int> numberList = new List<int>();

            int inputNumber = 0;
            int[] result = new int[5];
            string sortingType = "";


            Console.WriteLine(SOTRING_TYPE_MESSAGE);
            sortingType = Console.ReadLine();

            if (sortingType == "1")
                sortingType = "ascending";
            else
                sortingType = "descending";

            while (numberList.Count() != 5)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine(SORT5_MESSAGE);
                    inputNumber = Convert.ToInt32(Console.ReadLine());

                    numberList.Add(inputNumber);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error is: " + ex.Message);
                }
            }

            result = client.Sort5Number(sortingType, numberList.ToArray());

            string resultString = "";

            foreach(int item in result)
            {
                resultString += item.ToString() + ", ";
            }
            resultString = resultString.Substring(0, resultString.Length - 1);
            Console.WriteLine(SORT5_RESULT + resultString);

        }
    }
}
