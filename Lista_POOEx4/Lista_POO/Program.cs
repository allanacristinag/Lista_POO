
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
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Digite o valor da base do triângulo: ");
            triangulo.setBase(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            triangulo.setAltura(int.Parse(Console.ReadLine()));

            
            triangulo.calcularArea();
            Console.WriteLine(triangulo.getArea());
        }
    }
}
