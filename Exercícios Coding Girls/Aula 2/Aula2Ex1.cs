using System;
namespace Program
{
  public class Aula2
  {
    class Ex1
    {
      static void Main (string[] args)
      {
        Console.WriteLine("Insira seu ano de nascimento:");
        int ano = Convert.ToInt32(Console.ReadLine()); 
       
       
      int idade = 2022 - ano;
        
	    Console.WriteLine ($"Você tem ou terá {idade} anos neste ano.");
      }
    }
  }
}

