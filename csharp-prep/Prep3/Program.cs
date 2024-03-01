using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);


        int guessNumber;
        int i = 0;
        bool quit = false;
       
        do
        {
           

            Console.Write("What's your guess? ");
            string userGuess = Console.ReadLine();
            guessNumber = int.Parse(userGuess);

            i++;

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        
            else
            {
                Console.WriteLine($"You guessed it! It took you {i} tries.");
                Console.WriteLine("Do you want to play again? Yes/No ");
                string playAgain = Console.ReadLine();

                if (playAgain.ToLower() == "yes")
                {
                    i = 0;
                    quit = false;
                }
                else 
                {
                    quit = true;
                }
            }

        } while (!quit);

    }
}