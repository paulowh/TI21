using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a;
            float b;
            float soma;
            float subtracao;
            float multiplicacao;
            float divisao;
            float resto;

            //Console.Write("Hello World");

            Console.Write("Digite o 1º numero: ");
            a = float.Parse( Console.ReadLine() );

            Console.Write("Digite o 2º numero: ");
            b = float.Parse( Console.ReadLine() );

            soma = a + b; //Estamos somando os valores das variaveis a e b

            Console.WriteLine("A soma dos valores: " + soma); //WriteLine serve para quebrar a minha linha ao final

            subtracao = a - b; //Estamos subtraindo os valores das variaveis a e b

            Console.WriteLine("A subtração dos valores: " + subtracao);

            multiplicacao = a * b;

            Console.WriteLine("A multiplicação dos valores: " + multiplicacao);

            divisao = a / b;

            Console.WriteLine("A divisão dos valores: " + divisao);














            Console.ReadKey();

        }
    }
}
