using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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
            
            for(int i = 1; i < limit; i++)
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

            return charArray.ToString();
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
