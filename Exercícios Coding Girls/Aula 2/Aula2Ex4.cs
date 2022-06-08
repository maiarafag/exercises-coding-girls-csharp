using System;
namespace Program
{
  public class Aula2
  {
    class Ex4
    {
      static void Main (string[]args)
      {
	    Console.WriteLine ("Insira a sua idade: ");
     	int idade = Convert.ToInt32(Console.ReadLine());
     	
     	int ano = idade;
     	int meses = idade * 12;
     	int dias = 365 * idade * 12;

	    Console.WriteLine ($"Anos: {ano}\nMeses: {meses}\nDias: {dias}");
	  
      }
    }
  }
}