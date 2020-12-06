using System;
using System.Collections.Generic;

/*
* Write a program and ask the user to enter 5 numbers.
*
* If a number has been previously entered, display an error message
* and ask the user to re-try.
*
* Once the user successfully enters 5 unique numbers, sort them and display
* the result on the console.
*/

namespace practice.beginners.arrayslists
{
    public static class SortFiveUniqueNumbers
    {
        public static int Run()
        {
            Console.WriteLine("Enter 5 unique numbers");
            const int uniqueAmount = 5;

            var numbers = new List<int>();
            while (numbers.Count<uniqueAmount)
            {
                Console.WriteLine("Your number is: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                    Console.WriteLine("Provide a number that hasn't been used before");
                else
                    numbers.Add(number);
            }

            numbers.Sort();
            Console.WriteLine("Your previously mentioned numbers are sorted as follows:");
            numbers.ForEach(Console.WriteLine);

            return 0;
        }
    }
}
