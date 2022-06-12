using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor em R$: ");
            double valor = double.Parse(Console.ReadLine());

            double[] nota = { 100, 50, 20, 10, 5, 2 };

            int quantidadedenotas;

            Console.WriteLine("NOTAS:");

            for (int i = 0; i < 6; i++)
            {
                quantidadedenotas = (int)(valor / nota[i]);
                Console.WriteLine(quantidadedenotas + " nota(s) de R$ " + nota[i].ToString("0.00"));
                valor -= quantidadedenotas * nota[i];
                valor = Math.Round(valor, 2);
            }
            Console.ReadLine();
        }
    }
}
