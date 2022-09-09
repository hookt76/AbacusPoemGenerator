using System;
using System.IO;
using System.Text;

namespace DataAccess
{
    public class ReadIO
    {

        public string GetFile(string path)
        {
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            return readText;
        }
    }
}
