using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GettingStartedLib;
using GettingStartedClient.ServiceReference1;

namespace GettingStartedClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();

            double value1 = 100.00d;
            double value2 = 15.99d;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            value1 = 145.00d;
            value2 = 76.54d;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            value1 = 9.00d;
            value2 = 81.25d;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            value1 = 22.00d;
            value2 = 7.00d;
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            try
            {
                value1 = 22.0d;
                value2 = 0d;
                result = client.Divide(value1, value2);
                Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);
            }
            catch (FaultException<MathFault> ex)
            {
                Console.WriteLine(ex.Detail.ToString());
                client.Abort();
            }

            client.Close();

            Console.ReadLine();
        }
    }
}
