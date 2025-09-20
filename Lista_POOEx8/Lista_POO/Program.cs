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
           

            Console.WriteLine("Digite o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o asegundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            Comparar compararM = new Comparar(v1,v2);

            Console.WriteLine(compararM.getMaior());

        }
    }
}
