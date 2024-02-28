using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTestado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            float r = a / b;

            Console.WriteLine(String.Format("{0:F2}", r) + "\n");

            Console.ReadKey();

        }
    }
}
