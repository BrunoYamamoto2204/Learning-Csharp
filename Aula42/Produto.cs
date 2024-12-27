using System;

namespace Course{
    class Produto{

            public string Nome;
            public double Preco;
            public int Qntd;
            
            public double ValorTotalEmEstoque(){
                return Preco * Qntd;
            }
            
        }
    }
