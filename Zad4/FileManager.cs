using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public class FileManager
    {
        private string _myDocDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// Tworzy plik jezeli nie istnieje oraz zapisuje do niego zawartość.
        /// Nadpisuje aktualnie istniejący plik o tej samej nazwie
        /// </summary>
        /// <param name="obj">objekt do zapisu</param>
        /// <param name="fileName">nazwa pliku</param>
        public void SaveToFile(object obj, string fileName)
        {
            var path = Path.Combine(_myDocDir, fileName);

            using (Stream stream = File.Open(path, FileMode.OpenOrCreate))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, obj);
            }
        }

        /// <summary>
        /// Zczytuje zawartość pliku
        /// </summary>
        /// <param name="fileName">nazwa pliku</param>
        /// <returns></returns>
        public object LoadFromFile(string fileName)
        {
            var path = Path.Combine(_myDocDir, fileName);

            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                return bformatter.Deserialize(stream);
            }
        }
    }
}
