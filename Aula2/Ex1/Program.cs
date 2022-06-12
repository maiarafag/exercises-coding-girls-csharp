using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento:");
            int ano = Convert.ToInt32(Console.ReadLine());


            int idade = 2022 - ano;

            Console.WriteLine($"Você tem ou terá {idade} anos neste ano.");
            Console.ReadLine();
        }
    }
}
