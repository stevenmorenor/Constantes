using System;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window W = new Window();
            W.show();

        }
    }

    class Window
    {
        private int width, high;
        private string colour;
        public Window()
        {
            width = 20;
            high = 25;
            colour = "Red";
        }

        public void show()
        {
            Console.WriteLine("THE DIMENSION OF THE SCREEN IS: " + width + "x" + high + " THE COLOR IS: " + colour);
        }
        /*~Window() Destroyer
        {

        }
        */
    }
       
}
