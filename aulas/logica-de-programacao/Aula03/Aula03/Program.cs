using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, resultado;

            Console.Write("Digite um numero: ");
            a =  int.Parse( Console.ReadLine() );


            resultado = Math.Pow(a, 4);
            Console.WriteLine("O resultado = " + resultado);


            Console.Write("Digite um outro numero: ");
            b = int.Parse( Console.ReadLine() );


            resultado = Math.Sqrt(b);
            Console.WriteLine("O resultado = " + resultado);


            Console.ReadKey();
        }
    }
}
