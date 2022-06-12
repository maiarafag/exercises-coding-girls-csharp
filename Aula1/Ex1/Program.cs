using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Maiara";
            string endereco = "Rua zero";
            int cep = 12345789;
            int telefone = 980001111;

            Console.WriteLine($"Nome: {nome}\nEndereco: {endereco}\nCep: {cep}\nTelefone: {telefone}");
            Console.ReadLine();
        }
    }
}
