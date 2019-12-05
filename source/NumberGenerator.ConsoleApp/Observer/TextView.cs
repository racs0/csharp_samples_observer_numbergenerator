using NumberGenerator.Logic.Contracts;
using System;

namespace NumberGenerator.ConsoleApp.Observer
{
    class TextView : IObserver
    {
        public void Update(int nextNumber)
        {
            Console.WriteLine($"{nameof(TextView)}: {nextNumber}");
        }
    }
}
