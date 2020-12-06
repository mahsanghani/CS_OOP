using System;

/*
* Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
* Display the count on the console.
*/

namespace practice.beginners.controlflow
{
    public static class DivisibilityByThree
    {
        public static void Run()
        {
            Console.WriteLine("How many numbers are divisible by 3? {0}", CountNumbersDivisibleByThree());
        }

        private static int CountNumbersDivisibleByThree()
        {
            int count = 0;
            Console.WriteLine("Enter a count: ");
            int max = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < max; i+=3)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
