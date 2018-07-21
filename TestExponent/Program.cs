using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExponent
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            float y = 3.14F;

            float result = (float)Math.Pow(y, x);

            Console.WriteLine(String.Format("{0} raised to {1} power = {2}.", y, x, result));
            Console.ReadLine();
        }
    }
}
