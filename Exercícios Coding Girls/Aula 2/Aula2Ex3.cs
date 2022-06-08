using System;
namespace Program
{
  public class Aula2
  {
    class Ex3
    {
      static void Main (string[]args)
      {
    	Console.WriteLine ("Insira o nome do funcionario: ");
	    string nome = Console.ReadLine();
	    
	    Console.WriteLine ("Insira o numero de horas trabalhadas: ");
     	int horas = Convert.ToInt32(Console.ReadLine());
     	
     	Console.WriteLine ("Insira o valor que recebe por hora: ");
     	int valor = Convert.ToInt32(Console.ReadLine());
     	
     	float salario = horas * valor;

	    Console.WriteLine ($"Nome: {nome}");
	    Console.WriteLine(string.Format("Salario R$: {0:0.00}", salario));
      }
    }
  }
}
