using System;
using System.Reflection.Metadata.Ecma335;

namespace Course{
    class Moeda{
        public static double iof = 0.06;

        public static double ConversorDeMoeda(double preco, double dolares) {
            return (preco + preco * iof) * dolares;
        }
    }
}