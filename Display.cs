using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public delegate int OperationHandler(int a, int b);
    internal static class Display
    {
        public static void ShowResult(OperationHandler handler, int a, int b)
        {
            var res = handler(a, b);
            Console.WriteLine($"Result is : {res}");
        }
    }
}
