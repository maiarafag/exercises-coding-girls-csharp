using System;

namespace Ex4
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

            if (media >= 9.0 && media <= 10.0)
            {
                Console.WriteLine($"O aluno tirou A. Parabéns!");
            }
            else if (media >= 8.0 && media < 9.0)
            {
                Console.WriteLine($"O aluno tirou B. Parabéns!");
            }
            else if (media >= 7.0 && media < 8.0)
            {
                Console.WriteLine($"O aluno tirou C. Parabéns!");
            }
            else if (media >= 6.0 && media < 7.0)
            {
                Console.WriteLine($"O aluno tirou D. Dessa vez foi por pouco!");
            }
            else
                Console.WriteLine($"O aluno tirou F. Tente outra vez!");
            Console.ReadLine();
        }
    }
}
