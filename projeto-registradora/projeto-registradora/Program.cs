using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_registradora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string loop = "S";

            while (loop.ToUpper() == "S")
            {
                Console.WriteLine("1 - CADASTRAR novos produtos");
                Console.WriteLine("2 - Realizar VENDA de produtos");
                Console.WriteLine("3 - Gerar RELATORIO de produtos");
                Console.WriteLine("4 - Nossa area de testes !!!");
                menu = int.Parse(Console.ReadLine());

                //estrutura de escolha do menu
                if (menu == 1)
                {
                    Console.WriteLine("Você escolheu CADASTRAR UM PRODUTO");
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Você escolheu VENDER UM PRODUTO");
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Você escolheu gerar UM RELATORIO DOS PRODUTOS");
                }
                else if (menu == 4)
                {
                    Console.Write("Digite uma frase: ");
                    string frase = Console.ReadLine();

                    Console.WriteLine(frase.ToUpper());
                    Console.WriteLine(frase.ToUpperInvariant());
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção invalida");
                }

                Console.Write("Deseja continuar no sistema? (s/n) ");
                loop = Console.ReadLine();

            }














            Console.Write("Precione <enter> para finalizar...");
            Console.ReadKey();
        }
    }
}
