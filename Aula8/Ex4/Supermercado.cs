using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    public class Supermercado
    {
        public double PrecoProduto { set; get; }
        public string CodigoProduto { set; get; }
        public int Quantidade { set; get; }
        public string Item { set; get; }
        public string EspecificacaoProduto { set; get; }
        public double ValorTotal { set; get; }
        public string FormaPagamento { set; get; }


    }

   public class Cliente
    {
        public string Nome  { set; get; }
        public string Cpf  { set; get; }

    }

   public  class Produto : Supermercado
    {
        
         public string Descricao()
        {
            return "Produto";
        }
    }

   public  class Pedido : Supermercado
    {
        public string Descricao()
        {
            return "Pedido";
        }
        
    }
}
