using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Aluno
    {
        private string nome {get; set;}
        private string codigo {get; set;}
        private double notas {get; set;}
        private string frequencia {get; set;}

       public Aluno(string nome, string codigo, double notas, string frequencia)
       {
       this.nome = nome;
       this.codigo = codigo;
       this.notas = notas;
       this.frequencia = frequencia;
       CadastrodeAlunos();
       AdicionaNotas();
       ConsultaAlunoCodigo();
       ConsultaTodosAlunos();
       } 

        public void CadastrodeAlunos()
        {
            Console.WriteLine("Para cadastro do aluno, informe o nome, notas e frequência: ");
        }
        
        public void AdicionaNotas()
        {
            Console.WriteLine("A nota de " + nome + " é: " + notas);
        }

        public void ConsultaAlunoCodigo()
        {
            Console.WriteLine($"O aluno de código {codigo} é " + nome);
            
        }

        public void ConsultaTodosAlunos()
        {
            Console.WriteLine("O cadastro está no nome de " + nome);
        }

    }
}
