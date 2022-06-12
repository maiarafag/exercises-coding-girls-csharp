using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valorpar = new int[10];
            int[] valorimpar = new int[10];
            int num;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    valorpar[i] = num;
                }
                else
                {
                    valorimpar[i] = num;
                }

            }
            Console.WriteLine("Os numeros pares sao: ");
            for (int i = 0; i < 10; i++)
            {
                if (valorpar[i] != 0)
                {
                    Console.WriteLine(valorpar[i] + " é par");
                }
            }
            Console.WriteLine("Os numeros impares sao: ");

            for (int i = 0; i < 10; i++)
            {
                if (valorimpar[i] != 0)
                {
                    Console.WriteLine(valorimpar[i] + " é impar");
                }
            }
            Console.ReadLine();
        }

    }
}
