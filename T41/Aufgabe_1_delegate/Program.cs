using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1_delegate
{
    delegate int Del_Operation(int a, int b);
    class Program
    {
        static int Multiplikation(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Del_Operation del = new Del_Operation(Multiplikation);
            Console.WriteLine($"Erg = {del(4,7)}");
        }
    }
}
