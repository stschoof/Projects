using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Dateien
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Unterricht\Datei.txt";
            if(File.Exists(path))
            {
                File.Copy(@"E:\Unterricht\Datei.txt", @"E:\Unterricht1\Datei.txt");
                File.Delete(@"E:\Unterricht\Datei.txt");
                File.Move(@"E:\Unterricht1\Datei.txt", @"E:\Unterricht\Datei.txt");
            }
            else
            {
                File.Create(@"E:\Unterricht\Datei.txt").Close();
            }
        }
    }
}
