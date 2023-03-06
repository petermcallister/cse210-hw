using System;
using System.Linq;

namespace ScriptureMemorizationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scriptures = new string[] {
                "For God so loved the world that he gave his only begotten Son," +
                "that whosoever believeth in him should not perish but have everlasting life.",
                "For God sent not his Son into the world to condemn the world;" +
                "but that the world through him might be saved."
            };

            foreach (string scripture in scriptures)
            {
                string[] words = scripture.Split(' ');
                int index = 0;

                Console.WriteLine("Memorize the following scripture:\n");
                Console.WriteLine(scripture + "\n");

                while (index < words.Length)
                {
                    Console.WriteLine("Press Enter to replace a word with underscores...");
                    Console.ReadLine();

                    int randomIndex = new Random().Next(index, words.Length);
                    words[randomIndex] = new string('_', words[randomIndex].Length);

                    Console.WriteLine(string.Join(" ", words) + "\n");
                    index++;
                }

                Console.WriteLine("Type the scripture to check your memory:");
                string userInput = Console.ReadLine();

                if (userInput == scripture)
                {
                    Console.WriteLine("Congratulations! You have memorized the scripture.");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct scripture is:\n");
                    Console.WriteLine(scripture + "\n");
                }
            }
        }
    }
}
