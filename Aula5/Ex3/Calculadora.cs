using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Calculadora
    {

     public int ValorA { get; set; }
     public int ValorB { get; set; }
   

     public int Soma()
        {
            return this.ValorA + this.ValorB;
        }
     public int Subtracao()
        {
            return this.ValorA - this.ValorB;
        }
     public int Multiplicacao()
        {
            return this.ValorA * this.ValorB;
        }
     public int Divisao()
        {
            return this.ValorA / this.ValorB;
        }

    }
}
