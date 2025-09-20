using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor das milhas que gostaria de converter para km: ");
            int milhasr = int.Parse(Console.ReadLine());

            Milhas milhas = new Milhas();
            milhas.calcularMilhas();
            Console.WriteLine(milhas.getMilhasf());
        }
    }
}
