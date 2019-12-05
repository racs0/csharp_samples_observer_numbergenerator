using NumberGenerator.Logic.Contracts;
using System;

namespace NumberGenerator.ConsoleApp.Observer
{
    class BarView : IObserver
    {
        public void Update(int nextNumber)
        {
            Console.WriteLine($"{nameof(BarView)}: {new string('#', nextNumber)}");
        }
    }
}
