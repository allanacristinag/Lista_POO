using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base: ");
            double baze = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            double altura = double.Parse(Console.ReadLine());

            Terreno terreno = new Terreno(baze,altura);

            terreno.calcularArea();

            Console.WriteLine("O valor da área é:{0}.", terreno.getArea());
            Console.WriteLine(terreno.calcularTamanho());
        }
    }
}
