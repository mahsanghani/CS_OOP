using System;

namespace practice.intermediate.@interface
{
    public class FirstActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing first activity");
        }
    }
}
