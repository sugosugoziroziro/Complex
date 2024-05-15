using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1;
            Console.WriteLine(Complex.Tryparse("3+i5",out c1));
            Console.WriteLine(c1.ToString());
        }
    }
}
 