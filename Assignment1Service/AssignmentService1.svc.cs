using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1Service
{
    public class Service1 : IAssignmentService1
    {
        public string PrimeNumber(int primeNumber)
        {
            if (primeNumber <= 1)
                return "Not a prime number";
            if (primeNumber == 2)
                return "Prime number";
            if (primeNumber % 2 == 0)
                return "Not a prime number";

            int limit = (int)Math.Floor(Math.Sqrt(primeNumber));
            
            for(int i = 3; i < limit; i++)
            {
                if (primeNumber % i == 0)
                    return "Not a prime number";
            }

            return "Prime number";
        }
        public int Sum(int value)
        {
            int result = 0;

            foreach(char item in value.ToString())
            {
                result += int.Parse(item.ToString());
            }

            return result;
        }
        public string ReverseString(string initialString)
        {
            char[] charArray = initialString.ToCharArray();

            Array.Reverse(charArray);
           
            return new string(charArray);
        }
        public string PrintHTMLTag(string tag, string data)
        {
            return "<" + tag + ">" + data + "</" + tag + ">";
        }
        public int[] Sort5Number(string sortType, int[] array)
        {
            Array.Sort(array);
            if(sortType.ToLower() == "ascending")
            {
                return array;
            }
            else
            {
                Array.Reverse(array);
                return array;
            }
        }

    }
}
