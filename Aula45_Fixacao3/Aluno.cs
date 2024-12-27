using System;
using System.Globalization;

namespace Course{
    class Aluno{

        public string nome;
        public double n1;
        public double n2;
        public double n3;

        public double Media(){
            return (n1 + n2 + n3)/10;
        }

        public bool Aprovacao() {
            if (Media() >= 6.0){
                return true;
            }
            else {
                return false;
            }
        }

        public double Faltam() {
            return 6.0 - Media();
        }
    }
}