using System;
using System.Globalization;

namespace Course{
    class Produto{

        public string Nome;
        public double Preco;
        public int Qntd;
        
        public double ValorTotalEmEstoque(){
            return Preco * Qntd;
        }

        public void AdicionarProdutos(int qntd_add){
            Qntd += qntd_add;
        }

        public void RemoverProdutos(int qntd_retirada){
            Qntd -= qntd_retirada;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2",CultureInfo.InvariantCulture)
            + ", " + Qntd + " unidades, Total: $ "+ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
    }
