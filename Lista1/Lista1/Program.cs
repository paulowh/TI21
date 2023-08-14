using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pagamento, valor, troco;

            Console.WriteLine("Digite o valor total da compra: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor pelo CLIENTE: ");
            pagamento = float.Parse(Console.ReadLine());

            troco = pagamento - valor;

            Console.WriteLine("O valor do seu troco é: " + troco);

            float a, b, c;
            float soma, media;

            Console.Write("Digite o 1º numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3º numero: ");
            c = int.Parse(Console.ReadLine());

            soma = a + b + c;
            media = soma / 3;

            Console.WriteLine("O valor da média é: " + media);


            float celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em celsius: ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);



            Console.ReadKey();
        }
    }
}
