using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace GettingStartedLib
{
    [DataContract(Namespace = "http://Microsoft.ServiceMode1.Samples")]
    public class MathFault
    {
        private string operation;
        private string problemType;

        public MathFault(string operation, string problemType)
        {
            this.operation = operation;
            this.problemType = problemType;
        }

        [DataMember]
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        [DataMember]
        public string ProblemType
        {
            get { return problemType; }
            set { problemType = value; }
        }

        public override string ToString()
        {
            return string.Format("Operation: {0}, problemType: {1}",
                                Operation, ProblemType);
        }
    }
}