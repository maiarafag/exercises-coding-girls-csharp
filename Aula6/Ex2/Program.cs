using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
    Empregado empregado = new Empregado("Maiara", "Analista de Compras", 500.00);           
    Console.WriteLine("Nome: " + empregado.Nome);
    Console.WriteLine("Cargo: " + empregado.Cargo);

        }
    }
}
