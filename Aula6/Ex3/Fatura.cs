using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Fatura
    {
   
    public int Numero;
    public string Descricao;
    public int Quantidade;
    public double Preco;

    public Fatura(int numero, string descricao, int quantidade, double preco)
   {
       this.Numero = numero;
       this.Descricao = descricao;
       this.Quantidade = quantidade;
       this.Preco = preco;
       ValorFatura();  
    }

    public  void  ValorFatura(){
       Console.WriteLine("---Fatura---");
      }

    public int getNumero() {
       return Numero;
    }

   public void setNumero(int numero) {
       this.Numero = numero;
    }

   public string getDescricao() {
       return Descricao;
    }

   public void setDescricao(string descricao) {
       this.Descricao = descricao;
    }

   public int getQuantidade() {
       return Quantidade;
    }

   public void setQuantidade(int quantidade) {
       this.Quantidade = quantidade;
    }
    
    public double getPreco() {
       return Preco;
    }

   public void setPreco(double preco) {
       this.Preco = preco;
    }

    }
}
