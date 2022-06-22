using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
    Fatura fatura = new Fatura(1, "Mouse", 3, 30.50); 

    Console.WriteLine("Numero: " + fatura.Numero);
    Console.WriteLine("Descrição: " + fatura.Descricao);
    Console.WriteLine("Quantidade: " + fatura.Quantidade);
    Console.WriteLine(string.Format("Preço R$: {0:0.00}", fatura.Preco));
    Console.WriteLine(string.Format("Valor total da fatura R$: {0:0.00}", fatura.Quantidade*fatura.Preco));

        }
    }
}
