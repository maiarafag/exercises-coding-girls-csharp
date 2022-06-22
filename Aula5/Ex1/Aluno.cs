using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Aluno
    {
        public string Matricula { get; set; }

        public string Nome { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double NotaTrabalho { get; set; }

        public double Media { get; set; }

        public double NotaFinal { get; set; }

        //Método Calcular média

        public double CalcularMedia()
        {
            return this.Media;
        }

        //2 Método Calcular nota final

        public double CalcularNotaFinal()
        {
            return this.NotaFinal;
        }

    }
}
