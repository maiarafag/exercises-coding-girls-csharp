using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Empregado
    {
   
    public string Nome;
    public string Cargo;
    public double SalarioMensal;

     public Empregado(string nome, string cargo, double salarioMensal)
    {
        this.Nome = nome;
        this.Cargo = cargo;
        this.SalarioMensal = salarioMensal;

    if(salarioMensal < 0) {
       Console.WriteLine(string.Format("Salário mensal R$: {0:0.00}", salarioMensal));
       Console.WriteLine(string.Format("Novo salário mensal R$: {0:0.00}", salarioMensal*0.00));
        
    } 
    else if(salarioMensal < 400.00) {
       Console.WriteLine(string.Format("Salário mensal R$: {0:0.00}", salarioMensal));
       Console.WriteLine(string.Format("Novo salário mensal R$: {0:0.00}", salarioMensal*1.15));
     
    }
    else if(salarioMensal < 800.00) {
      Console.WriteLine(string.Format("Salário mensal R$: {0:0.00}", salarioMensal));
      Console.WriteLine(string.Format("Novo salário mensal R$: {0:0.00}", salarioMensal*1.12));
    
    }
    else if(salarioMensal < 1200.00) {
       Console.WriteLine(string.Format("Salário mensal R$: {0:0.00}", salarioMensal));
       Console.WriteLine(string.Format("Novo salário mensal R$: {0:0.00}", salarioMensal*1.10));
      
    }
    else if(salarioMensal < 2000.00) {
      Console.WriteLine(string.Format("Salário mensal R$: {0:0.00}", salarioMensal));
      Console.WriteLine(string.Format("Novo salário mensal R$: {0:0.00}", salarioMensal*1.07));
    }
    else{
        Console.WriteLine(string.Format("Salário mensal R$: {0:0.00}", salarioMensal));
        Console.WriteLine(string.Format("Novo salário mensal R$: {0:0.00}", salarioMensal*1.04));
    }
    }
    }
}
