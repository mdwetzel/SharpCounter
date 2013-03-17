using System;
using System.Text;

namespace SharpCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to count its words: ");
            string input = Console.ReadLine();

            int words = CountWordsByCharacter(input);

            // words = CountWordWithSplit(input);

            Console.WriteLine("There are {0} words.", words);

            Console.ReadLine();
        }

        // I could just be lazy, but, nah.
        private static int CountWordsByCharacter(string input)
        {
            int words = 0;
            for (int i = 0; i < input.Length; i++) {
                // i == input.Length - 1 = final word. 
                if (input[i] == ' ' || i == input.Length - 1) {
                    words++;
                }
            }
            return words;
        }

        // The easy way.
        private static int CountWordWithSplit(string input)
        {
            return input.Split(' ').Length;
        }
    }
}
