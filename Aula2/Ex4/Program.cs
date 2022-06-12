using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int ano = idade;
            int meses = idade * 12;
            int dias = 365 * idade * 12;

            Console.WriteLine($"Anos: {ano}\nMeses: {meses}\nDias: {dias}");
            Console.ReadLine();
        }
    }
}
