using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dateien1
{
    class Program
    {
        static void Main(string[] args)
        {
            //public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
            FileStream stream = File.Open(@"E:\Unterricht\Datei.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            stream.Close();

            File.WriteAllText(@"E:\Unterricht\Datei.txt", "das soll in die datei");
            Console.WriteLine(File.ReadAllText(@"E:\Unterricht\Datei.txt"));

            Console.ReadLine();

            FileInfo meineDatei = new FileInfo(@"E:\Unterricht\Datei.txt");
            if(0!=(meineDatei.Attributes & FileAttributes.Normal))
            {
                //wenn die Datei versteckt ist ......
            }

            meineDatei.Attributes = meineDatei.Attributes ^ FileAttributes.Hidden;

            Directory.Exists(@"E:\Unterricht\");
            DirectoryInfo meinVerzeichnis = new DirectoryInfo(@"E:\Unterricht\");
        }
    }
}
