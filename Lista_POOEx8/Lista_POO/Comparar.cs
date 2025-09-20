using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POO
{
    internal class Comparar
    {
        int v1;
        int v2;
        int maior;

       
        public Comparar(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            CalcularMaior();
        }
        private void CalcularMaior()
        {
            if (v1 > v2)
                maior = v1;
            else if (v2 < v1)
                maior = v2;
            else
                maior = -1;
        }
       
        


        public void setV1(int v1)
        {
            this.v1 = v1;
        }
        public void setV2(int v2)
        {
            this.v2 = v2;
        }
       
        public string getMaior()
        {
            if (v1 == v2)
                return "os números são idênticos!";
            else if (v1 > v2)
                return "O maior número é: " + v1;
            else
                return "O maior número é: " + v2;
        }
    }
}
