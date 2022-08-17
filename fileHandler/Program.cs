using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter NewArchiveTest = File.AppendText("test.txt");
            NewArchiveTest.WriteLine("Lucas");
            NewArchiveTest.WriteLine("Ivana");
            NewArchiveTest.WriteLine("Teste");
            NewArchiveTest.Close();

            StreamReader readerArchive = new StreamReader("test.txt");
            List<string> contentArchive = new List<string>();
            string linesArchive = "";

            while(linesArchive != null)
            {
                linesArchive = readerArchive.ReadLine();
                if (linesArchive != null)
                {
                    contentArchive.Add(linesArchive);
                }
            }
            readerArchive.Close();
            foreach (string line in contentArchive)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
            
        }
    }
}
