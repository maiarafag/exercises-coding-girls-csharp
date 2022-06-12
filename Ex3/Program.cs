using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira tres notas de um aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7.0)
            {
                Console.WriteLine($"O aluno tirou {media} e foi aprovado.");
            }
            else
                Console.WriteLine($"O aluno tirou {media} e foi reprovado.");
            Console.ReadLine();
        }
    }
}
