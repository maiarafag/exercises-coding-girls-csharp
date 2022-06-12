using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o numero de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor que recebe por hora: ");
            float valor = float.Parse(Console.ReadLine());

            float salario = horas * valor;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine(string.Format("Salario R$: {0:0.00}", salario));
            Console.ReadLine();
        }
    }
}
