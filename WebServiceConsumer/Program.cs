using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceConsumer.CalServiceReference;

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
            int c = myMathService.Add(56, 62);
            Console.WriteLine(c);
            //Console.Write("2 + 4 = {0}", myMathService.Add(2,4));
        }
    }
}
