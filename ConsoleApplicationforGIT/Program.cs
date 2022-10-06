using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationforGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}",num1, num2, result);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}
