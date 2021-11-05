
using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Professor.NumStudent("25"));
            Student.PassMatter();
            Console.WriteLine(Person.Born());
            //Contar(1, 8);
            //Console.WriteLine(Saludo("Juan"));
            // num = Sumar();
            //Console.WriteLine(num);
        }
        #region NO UTILIZADA
        static int Sumar()
        {
            int suma = 2 + 2;
            return suma;
        }
        static string Saludo(string nombre)
        {
            string saludo = "Hola " + nombre + " Que tal";
            return saludo;
        }

        static void Contar(int x, int y)
        {
            for (int contador = x; contador <= y ; contador++)
            {
                Console.WriteLine(contador);
            }
        }

        #endregion
    }
}
