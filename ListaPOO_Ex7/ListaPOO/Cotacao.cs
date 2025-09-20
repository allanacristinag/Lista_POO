using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO
{
    internal class Cotacao
    {
        int cotacao;
        int dolar;
        int reais;

        public Cotacao()
        {
            this.cotacao = 0;
            this.dolar = 0;
            this.reais = 0;
        }
        public Cotacao(int cotacao,int dolar,int reias)
        {
            this.cotacao = cotacao;
            this.dolar = dolar;
            this.reais = reais;
        }
        public void setCotacao(int cotacao)
        {
            this.cotacao = cotacao;
        }
        public void setDolar(int dolar)
        {
            this.dolar = dolar;
        }
        public int getCotacao()
        {
            return this.cotacao;
        }
        public int getDolar()
        {
            return this.dolar;
        }
        public int getReais()
        {
            return this.reais;
        }
        public void calcularReais()
        {
            this.reais = this.cotacao * this.dolar;
        }
            

        

    }
}
