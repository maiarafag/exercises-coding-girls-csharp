using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dez valores: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            int soma = a + b + c + d + e + f + g + h + i + j;

            Console.WriteLine($"A soma dos números será: {soma}");
            Console.ReadLine();
        }
    }
}
