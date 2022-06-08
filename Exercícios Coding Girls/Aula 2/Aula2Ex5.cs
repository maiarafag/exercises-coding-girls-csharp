using System;
namespace Program
{
  public class Aula2
  {
    class Ex5
    {
      static void Main (string[]args)
      {
	    Console.WriteLine ("Insira um valor em R$: ");
     	double valor = double.Parse(Console.ReadLine());
     	
     	double dolar  = valor * 4.87;
     	double euro  = valor * 5.21;
     	double libra  = valor * 6.12;
     	double dolarcan  = valor * 3.88;
        double pesoarg  = valor * 0.040;
        double pesochi  = valor * 0.0059;
	    
	    Console.WriteLine(string.Format("\nDolar: US$ {0:0.00}", dolar));  
	    Console.WriteLine(string.Format("Euro: € {0:0.00}", euro));
	    Console.WriteLine(string.Format("Libra esterlina: £ {0:0.00}", libra));
	    Console.WriteLine(string.Format("Dolar canadense: C$ {0:0.00}", dolarcan));
	    Console.WriteLine(string.Format("Peso argentino: $ {0:0.00}", pesoarg));
	    Console.WriteLine(string.Format("Peso chileno: CLP$ {0:0.00}", pesochi));
      }
    }
  }
}