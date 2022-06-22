using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno("Maiara", "1", 8.5, "80%");
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("Código: " + aluno1.codigo);
            Console.WriteLine("Nota: " + aluno1.notas);
            Console.WriteLine("Frequência: " + aluno1.frequencia);

            Console.WriteLine("\n");

            Aluno aluno2 = new Aluno("Julia", "2", 7.6, "85%");
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("Código: " + aluno2.codigo);
            Console.WriteLine("Nota: " + aluno2.notas);
            Console.WriteLine("Frequência: " + aluno2.frequencia);
            Console.WriteLine("\n");
            
            aluno1.ConsultaTodosAlunos();
            aluno2.ConsultaTodosAlunos();
        }
    }
}
