using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceConsumer.CalcServiceReference;

namespace WebServiceConsumer
{
    class Program
    {
        //https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/write-web-service

        static void Main(string[] args)
        {
            ConsumeWebService();
        }

        static void ConsumeWebService()
        {
            CalculationWebServiceSoapClient myMathService = new CalculationWebServiceSoapClient();
            int c = myMathService.Add(6, 4);
            Console.WriteLine(c);
            var v = myMathService.GetEmployeeByID(6);

            
            Console.WriteLine(myMathService.HelloWorld());
            Console.ReadLine();
        }
    }
}
