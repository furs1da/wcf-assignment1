using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAssignmentService1
    {

        [OperationContract]
        string PrimeNumber(int primeNumber);

        [OperationContract]
        int Sum(int value);

        [OperationContract]
        string ReverseString(string initialString);

        [OperationContract]
        string PrintHTMLTag(string tag, string data);


        [OperationContract]
        int[] Sort5Number(string sortType, int[] array);

    }
}
