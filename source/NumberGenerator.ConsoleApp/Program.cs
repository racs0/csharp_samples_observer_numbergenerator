using NumberGenerator.Logic;

namespace NumberGenerator.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            MyNumberGenerator generator = new MyNumberGenerator();
            generator.Start();
        }
    }
}
