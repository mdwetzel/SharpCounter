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

            // I could just be lazy, but, nah.

            int words = 0;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] == ' ' || i == input.Length - 1) {
                    words++;
                }
            }

            Console.WriteLine("There are {0} words.", words);

            Console.ReadLine();
        }
    }
}
