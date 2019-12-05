using NumberGenerator.ConsoleApp.Observer;
using NumberGenerator.Logic;

namespace NumberGenerator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumberGenerator generator = new MyNumberGenerator();

            generator.Attach(new BarView());
            generator.Attach(new TextView());
            generator.Attach(new CountView());
            generator.Attach(new SumView());

            generator.StartGeneration();
        }
    }
}
