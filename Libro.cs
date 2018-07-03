using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
   
    public class Libro
    {
        [Serializable]
        public class Book
        {
            public string Nombre { get; set; }
            public string Autor { get; set; }
            public string Editorial { get; set; }


            public Book (string nombre, string autor, string editorial)
        {
            this.Nombre = nombre;
            this.Autor = autor;
            this.Editorial = editorial;
        }

         
        
    }

        public static List<Book> biblioteca = ReadFromBinaryFile<List<Book>>("biblioteca.txt");

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)

        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

    }
}



