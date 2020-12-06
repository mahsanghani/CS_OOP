using System;
using System.Collections.Generic;
using System.Linq;

/*
* Write a program and ask the user to continously enter a number or type "Quite"
* to exit. The list of numbers may include duplicates. Display the unique numbers
* that the user has entered.
*/

namespace practice.beginners.arrayslists
{
    public static class DisplayUniqueNumbers
    {
        public static int Run()
        {
            Console.WriteLine("Enter whatever number you like or 'quit' to exit out and view the results");

            var numbers = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input != null && input.ToLower() == "quit")
                {
                    var uniqueNumbers = GetUniqueNumbersList(numbers);
                    uniqueNumbers.Sort();
                    uniqueNumbers.ForEach(Console.WriteLine);
                    return 0;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            }
        }

        private static List<int> GetUniqueNumbersList(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(number => number)
                .Where(number => number.Count() == 1)
                .SelectMany(number => number)
                .ToList();
        }
    }
}
