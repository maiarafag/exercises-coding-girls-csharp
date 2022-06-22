using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.Matricula = "1";
            aluno.Nome = "Maiara";
            aluno.Nota1 = 6.5;
            aluno.Nota2 = 7.5;
            aluno.NotaTrabalho = 10;
            aluno.Media = (aluno.Nota1 + aluno.Nota2) / 2;
            aluno.NotaFinal = (aluno.Media + aluno.NotaTrabalho);

            Console.WriteLine("A aluna " + aluno.Nome + " tem o número de matrícula número " + aluno.Matricula + " e  possui a média de " + aluno.Media +
           " e nota final de " + aluno.NotaFinal + ".");

            Console.ReadLine();

        }
    }
}
