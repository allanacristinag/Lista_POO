using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO
{
    internal class Milhas
    {
        int milhasr;
        
        int milhasf;

        public Milhas()
        {
            this.milhasr = 0;
            
            this.milhasf = 0;
        }
        public Milhas(int milhasr,int milhasf)
        {
            this.milhasr = milhasr;
            
            this.milhasf = milhasf;
        }

        public void setMilhasr(int milhasr)
        {
            this.milhasr = milhasr;
        }
        public int getMilhasr()
        {
            return this.milhasr;
        }
       
        public int getMilhasf()
        {
            return this.milhasf;
        }
        public void calcularMilhas()
        {
            this.milhasf = this.milhasr * 1852;
        }


    }
}
