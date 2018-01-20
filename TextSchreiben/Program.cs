using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextSchreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"e:\unterricht\writer.txt");

            writer.WriteLine("heute ist Dienstag");
            writer.WriteLine("und morgen Mittwoch");
            writer.Close();

            StreamReader reader = new StreamReader(@"e:\unterricht\writer.txt");
            while(reader.Peek() != -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();

            reader = new StreamReader(@"e:\unterricht\writer.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.ReadLine();
        }
    }
}
