using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClientWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            GenLibService.GenLibClient client = new GenLibService.GenLibClient();
            GenLibService.FittestValue result = client.Start(0.65, 0.08, 5, 100, 10000);
            Console.WriteLine("x : {0} ; y : {1} ; fit : {2}", result.X, result.Y, result.Fit);
        }
    }
}
