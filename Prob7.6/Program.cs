using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = readFile();

            Console.WriteLine("Enter a name to search for: ");
            string name = Console.ReadLine();

            bool found = binarySearch(name, names);

            if (found)
            {
                Console.WriteLine($"{name} was found in the list.");
            }
            else
            {
                Console.WriteLine($"{name} was not found in the list.");
            }

            Console.ReadLine();

        }

        static List<string> readFile()
        {
            List<string> names = new List<string>();

            StreamReader file = new StreamReader("popular_names.txt");

            while (!file.EndOfStream)
            {

                names.Add(file.ReadLine());

            }

            file.Close();

            return names;
        }

        static bool binarySearch(string name, List<string> names)
        {

            names.Sort();

            int first = 0;
            int last = names.Count - 1;
            int middle;
            bool found = false;

            while (!found && first <= last)
            {
                middle = (first + last) / 2;

                if (names[middle].CompareTo(name) == 0)
                {
                    found = true;
                }
                else if (names[middle].CompareTo(name) > 0)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }
            }

            return found;

        }
    }
}
