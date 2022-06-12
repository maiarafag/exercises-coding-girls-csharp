using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salario: ");
            double salario = double.Parse(Console.ReadLine());


            if (salario > 0 && salario <= 400.00)
            {
                double p = 0.15;
                double reajuste = (p * salario);
                double salarionovo = reajuste + salario;

                Console.WriteLine(string.Format("Reajuste ganho: {0:0.00}", reajuste));
                Console.WriteLine(string.Format("Novo salario: {0:0.00}", salarionovo));
                Console.WriteLine($"Em percentual: 15 %");
            }
            else if (salario > 400.01 && salario <= 800.00)
            {
                double p = 0.12;
                double reajuste = (p * salario);
                double salarionovo = reajuste + salario;

                Console.WriteLine(string.Format("Novo salario: {0:0.00}", salarionovo));
                Console.WriteLine(string.Format("Reajuste ganho: {0:0.00}", reajuste));
                Console.WriteLine($"Em percentual: 12 %");
            }
            else if (salario > 800.01 && salario <= 1200.00)
            {
                double p = 0.10;
                double reajuste = (p * salario);
                double salarionovo = reajuste + salario;

                Console.WriteLine(string.Format("Novo salario: {0:0.00}", salarionovo));
                Console.WriteLine(string.Format("Reajuste ganho: {0:0.00}", reajuste));
                Console.WriteLine($"Em percentual: 10 %");
            }
            else if (salario > 1200.01 && salario <= 2000.00)
            {
                double p = 0.07;
                double reajuste = (p * salario);
                double salarionovo = reajuste + salario;

                Console.WriteLine(string.Format("Novo salario: {0:0.00}", salarionovo));
                Console.WriteLine(string.Format("Reajuste ganho: {0:0.00}", reajuste));
                Console.WriteLine($"Em percentual: 7 %");

            }
            else
            {
                double p = 0.04;
                double reajuste = (p * salario);
                double salarionovo = reajuste + salario;

                Console.WriteLine(string.Format("Novo salario: {0:0.00}", salarionovo));
                Console.WriteLine(string.Format("Reajuste ganho: {0:0.00}", reajuste));
                Console.WriteLine($"Em percentual: 4 %");
            }
            Console.ReadLine();
        }
    }
}
