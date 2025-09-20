using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POO
{
    internal class Terreno
    {
        double baze;
        double altura;
        double area;
        double tamanho;

        public Terreno(double baze, double altura)
        {
            this.baze = baze;
            this.altura = altura;
        }
        public void setBaze()
        {
            this.baze = 0;
        }
        public void setAltura()
        {
            this.altura = 0;
        }
        public double getArea()
        {
            return this.area;
        }
        public void calcularArea()
        { 
            this.area = this.baze * this.altura;
        }

       

        public string calcularTamanho()
        {
            if (this.area > 100)
                return "Terreno grande!";
            else
                return "Terreno pequeno!";
        }
        
           
        
        
       
    }
   
}
