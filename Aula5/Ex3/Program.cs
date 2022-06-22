using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Calculadora calcula = new Calculadora();
            
            calcula.ValorA = 10;
            calcula.ValorB = 5; 

            Console.WriteLine($"A soma dos valores é: {calcula.ValorA+calcula.ValorB}" );
            Console.WriteLine($"A subtração dos valores é: {calcula.ValorA-calcula.ValorB}" );
            Console.WriteLine($"A multiplicação dos valores é: {calcula.ValorA*calcula.ValorB}" );
            Console.WriteLine($"A divisão dos valores é: {calcula.ValorA/calcula.ValorB}" ); 

            Console.ReadLine();
        }
    }
}
