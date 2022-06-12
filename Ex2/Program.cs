using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira tres valores diferentes: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor3 > valor2 && valor3 > valor1)
            {
                Console.WriteLine($"{valor3} é o maior.");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine($"{valor2} é o maior.");
            }
            else
            {
                Console.Write($"{valor1} é o maior.");
            }
            Console.ReadLine();
        }
    }
}
