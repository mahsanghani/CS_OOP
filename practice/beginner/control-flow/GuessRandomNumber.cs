using System;

/*
* Write a program that picks a random number between 1 and 10.
* Give the user 4 chances to guess the number.
* If the user guesses the number, display "You won"; otherwise, display "You lost".
* (To make sure the program is behaving correctly, yo can display the secret number
* on console first.)
*/

namespace practice.beginners.controlflow
{
    public static class GuessRandomNumber
    {
        public static void Run()
        {
            Console.WriteLine("Try to guess a number from 1 to 10. You have 4 chances");
            var randomNumber = GenerateRandomNumber();
            AttemptToGuess(randomNumber);
        }

        private static int GenerateRandomNumber()
        {
            var random = new Random();
            return random.Next(1, 10);
        }

        private static void AttemptToGuess(int randomNumber)
        {
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Try #{0}: ", i);
                var answer = Convert.ToInt32(Console.ReadLine());

                if (answer == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }

                if (IsOutOfTries(i))
                {
                    Console.WriteLine("You lost. The correct number was {0}.", randomNumber);
                    break;
                }

                Console.WriteLine("Wrong guess, try again!");
            }
        }

        private static bool IsOutOfTries(int i)
        {
            return i == 3;
        }
    }
}
