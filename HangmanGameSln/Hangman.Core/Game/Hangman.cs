using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {
            _renderer.Render(5, 5, 6);

            string[] wordsOfGame = new string[23];
            wordsOfGame[0] = "alpha";
            wordsOfGame[1] = "beta";
            wordsOfGame[2] = "gamma";
            wordsOfGame[3] = "delta";
            wordsOfGame[4] = "epsilon";
            wordsOfGame[5] = "zeta";
            wordsOfGame[6] = "eta";
            wordsOfGame[7] = "theta";
            wordsOfGame[8] = "iota";
            wordsOfGame[9] = "kappa";
            wordsOfGame[10] = "lambda";
            wordsOfGame[11] = "mu";
            wordsOfGame[12] = "nu";
            wordsOfGame[13] = "xi";
            wordsOfGame[14] = "omnicron";
            wordsOfGame[15] = "pi";
            wordsOfGame[16] = "rho";
            wordsOfGame[17] = "sigma";
            wordsOfGame[18] = "tau";
            wordsOfGame[19] = "uplison";
            wordsOfGame[20] = "phi";
            wordsOfGame[21] = "chi";
            wordsOfGame[22] = "psi";
            wordsOfGame[23] = "omega";

            Random random = new Random();
            string randomOfWords = wordsOfGame[random.Next(wordsOfGame.Length)];

            
           
                
                
                
            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();
        }

    }
}
