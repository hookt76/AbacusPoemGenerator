using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Rules;
using BusinessLayer;

namespace AbacusPoemGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Path");
            var dirPath = @"" + Console.ReadLine();

            Console.WriteLine("Enter Delimiter");
            var delimiter = @"" + Console.ReadLine();

            Console.WriteLine("A Timer was added to allow a variance of words, the results will show");

            PoemBuilder poemBuilder = new PoemBuilder();
            char[] seperator = new char[1];
            seperator[0] = delimiter.Substring(0,1).ToCharArray()[0];
            var result = poemBuilder.GetPoem(dirPath, seperator);
            foreach (var item in result)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
