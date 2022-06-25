using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Maiara";
            cliente.Cpf = "12345678911";
            Console.WriteLine("---Dados do Cliente---");
            Console.WriteLine("Nome: " + cliente.Nome + "\nCPF: " + cliente.Cpf);

            Produto produto = new Produto();
            produto.Item = "Detergente";
            produto.CodigoProduto = "123";
            produto.EspecificacaoProduto = "Produto de Limpeza";
            produto.Quantidade = 2;
            produto.PrecoProduto = 2.00;
            produto.ValorTotal = 4.00;
            produto.FormaPagamento = "Dinheiro";
            Console.WriteLine("\n---Dados da Compra---");
            Console.WriteLine("Código do Produto: " + produto.CodigoProduto + "\nEspecificação do Produto: " + produto.EspecificacaoProduto
             + "\nProduto: " + produto.Item + "\nQuantidade: " + produto.Quantidade + "\nPreço Unitário: R$ " + produto.PrecoProduto +
             "\nValor Total: R$ " + produto.ValorTotal + "\nForma de Pagamento: " + produto.FormaPagamento);


        }
    }
}
