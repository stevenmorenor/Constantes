using System;

namespace Exampol
{
    internal class Program
    {
        public const decimal Pi = 3.1415m;
        static void Main(string[] args)
        {
            Console.WriteLine(Constantes.Demo.Text);
            decimal G = Constantes.Demo.Gravity;
            Console.WriteLine("The gravity is {0}", G);
            int Week = Constantes.Demo.Days;
            Console.WriteLine("The days of week are: {0}", Week);

            foreach (var day in System.Enum.GetValues(typeof(Constantes.Days)))
            {
                Console.WriteLine(day);
            }
            decimal x = Pi;
            Console.WriteLine(x);
        }
    }
}
