using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GettingStartedLib
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceMode1.Samples")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Subtract(double n1, double n2);

        [OperationContract]
        double Multiply(double n1, double n2);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        double Divide(double n1, double n2);
    }
}
