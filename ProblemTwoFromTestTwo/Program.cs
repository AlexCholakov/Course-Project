using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {

            const string outputPath = @"C:\Users\fmi\Desktop\Intro-to-programming-course-2016-master\Exercises\FileFile.txt";
            string[] towns = FillArrayWithNames(outputPath);
            Console.Write("Towns in the array: ");
            Console.WriteLine(towns.Length);

            int AverageLenght = FindAverageNameLength(towns);
            Console.WriteLine("The average city lenght is {0} letters.", AverageLenght);

            Console.WriteLine("The cities with names bellow the average lenght are: ");
            foreach (string name in towns)
            {
                if (name.Length < AverageLenght)
                {
                    Console.WriteLine(name);
                }
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("The cities which end with ovo are: ");
            EndsWithOvo(towns);

            Console.WriteLine("------------------------------------------------------");
            ContainsInterval(towns);

            Console.WriteLine("------------------------------------------------------");
            ContainsО(towns);
        }

        private static string[] FillArrayWithNames(string outputPath)
        {
            List<string> townsNames = new List<string>();
            StreamReader reader = new StreamReader(outputPath);
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    townsNames.Add(currentLine.Substring(0, currentLine.Length - 1));
                    currentLine = reader.ReadLine();
                }
            }
            return townsNames.ToArray();
        }

        public static int FindAverageNameLength(string[] towns)
        {
            int counter = 0;
            foreach (string name in towns)
            {
                counter += name.Length;
            }
            int averageLength = counter / towns.Length;
            return averageLength;
        }

        public static void EndsWithOvo(string[] towns)
        {
            foreach (string name in towns)
            {
                if (name.EndsWith("ово"))
                {
                    Console.WriteLine(name);
                }
            }
        }

        public static void ContainsInterval(string[] towns)
        {

            foreach (string name in towns)
            {
                if (name.Contains(" ") == true)
                {
                    Console.WriteLine(name);
                }
            }

        }

        public static void ContainsО(string[] towns)
        {
            int counter = 0;
            foreach (string name in towns)
            {
                if (name.Contains("о") && name.Contains("О") == true)
                {
                    counter++;
                    if (counter > 3)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

        }


    }
}