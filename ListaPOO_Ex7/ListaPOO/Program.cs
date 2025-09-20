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
            Console.WriteLine("Digite o valor atual da cotação do dólar: ");
            int cotacaoo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de dólares que deseja: ");
            int dolar = int.Parse(Console.ReadLine());

            Cotacao cotacao = new Cotacao(cotacaoo, dolar);
            cotacao.calcularReais();
            Console.WriteLine(cotacao.getReais());
        }
    }
}
