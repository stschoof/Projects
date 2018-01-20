using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace WpfAutoSerialisieren
{
 
    public class Datei
    {
                
        public static void Serialisieren(string pfad, object obj)
        {
            FileStream fileStream = new FileStream(pfad, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream,obj);
            fileStream.Close();
        }
       
        public static Object Deserialisieren(string pfad)
        {
            FileStream fileStream = new FileStream(pfad, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            object obj= formatter.Deserialize(fileStream);
            fileStream.Close();
            return obj;
        }
    }
}