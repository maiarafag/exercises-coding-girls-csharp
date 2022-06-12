using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresa = new int[10];
            int[] valoresb = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                valoresa[i] = int.Parse(Console.ReadLine());
                valoresb[i] = (valoresa[i] * 5);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"O valor {valoresa[i]} multiplicado por 5 e igual a {valoresb[i]}.");
            }
            Console.ReadLine();
        }
    }
}

