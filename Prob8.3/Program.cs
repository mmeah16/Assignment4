using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            
            string output = FirstUpper(input);

            Console.WriteLine(output);

            Console.ReadLine();

        }

        private static string FirstUpper(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsPunctuation(input[i]))
                {
                    
                    if(i + 2 < input.Length)
                    {
                        sb.Append(input[i]);
                        sb.Append(" ");
                        sb.Append(char.ToUpper(input[i + 2]));
                        i += 2;
                    }
                    else
                    {
                        sb.Append(input[i]);
                    }
                    
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }
    }
}
