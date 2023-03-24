using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 3;
            string secretWord = "informatica";
            string guessedWord = "";

            while (guessedWord != secretWord)
            {
                Console.Write("Enter guess: ");
                guessedWord = Console.ReadLine();
                guesses--;
                if (guesses < 1){
                    Console.WriteLine("Je hebt gefaald");
                    guessedWord = secretWord;
                    Console.Read();
                }
            }
            Console.WriteLine("You've won!");
            Console.ReadLine();
        }
    }
}