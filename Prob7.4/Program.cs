using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] answers = { { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' }, { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A' }, { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' } };

            int correct = 0;
            int incorrect = 0;

            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Exam1.txt");

                while (!inputFile.EndOfStream)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        answers[1,i] = Convert.ToChar(inputFile.ReadLine());
                    }
                }

                inputFile.Close();

                for (int i = 0; i < 20; i++)
                {
                    if (answers[1,i] == answers[0,i])
                    {
                        correct++;
                        answers[2, i] = '1';
                    }
                    else
                    {
                        incorrect++;
                        answers[2, i] = '0';
                    }
                }

                if(correct >= 15)
                {
                    Console.WriteLine("The student passed the exam.");
                }
                else
                {
                    Console.WriteLine("The student failed the exam.");
                }

                Console.WriteLine($"The student got {correct} correct answers and {incorrect} incorrect answers.");

                Console.WriteLine("The student got the following questions wrong: ");
                for (int i = 0; i < 20; i++)
                {
                    if (answers[2, i] == '0')
                    {
                        Console.WriteLine($"Question {i + 1}");
                    }
                }  
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }
    }
}
