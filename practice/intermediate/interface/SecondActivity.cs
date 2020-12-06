using System;

namespace practice.intermediate.@interface
{
    public class SecondActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing second activity");
        }
    }
}
