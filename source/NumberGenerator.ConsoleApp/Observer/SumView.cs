using NumberGenerator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGenerator.ConsoleApp.Observer
{
    class SumView : IObserver
    {
        private int _sum = 0;

        public void Update(int nextNumber)
        {
            _sum += nextNumber;
            Console.WriteLine($"{nameof(SumView)}: {_sum}");
        }
    }
}
