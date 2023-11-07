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
            string nomeProduto1 = "Coxinha", nomeProduto2 = "Agua", nomeProduto3 = "";
            double valor1 = 6.5 , valor2 = 2.50, valor3;
            int quantidade1 = 3, quantidade2 = 10, quantidade3;

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(" _____  _       _                                  _           _____                   ___               \r\n/  ___|(_)     | |                                | |         /  ___|                 |_  |              \r\n\\ `--.  _  ___ | |_   ___  _ __ ___    __ _     __| |  ___    \\ `--.   ___  _   _       | |  __ _   ___  \r\n `--. \\| |/ __|| __| / _ \\| '_ ` _ \\  / _` |   / _` | / _ \\    `--. \\ / _ \\| | | |      | | / _` | / _ \\ \r\n/\\__/ /| |\\__ \\| |_ |  __/| | | | | || (_| |  | (_| || (_) |  /\\__/ /|  __/| |_| |  /\\__/ /| (_| || (_) |\r\n\\____/ |_||___/ \\__| \\___||_| |_| |_| \\__,_|   \\__,_| \\___/   \\____/  \\___| \\__,_|  \\____/  \\__,_| \\___/ \r\n                                                                                                         \r\n                                                                                                         ");
            Console.ResetColor();

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
                    //Console.WriteLine("Você escolheu CADASTRAR UM PRODUTO");
                    //ter cerca de 3 produtos cadastraveis

                    Console.Write("Nome do 1º Produto: ");
                    nomeProduto1 = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque do" + nomeProduto1 + ": ");
                    quantidade1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto1 + ": ");
                    valor1 = float.Parse(Console.ReadLine());


                }
                else if (menu == 2)
                {
                    Console.Write("1-"+nomeProduto1+" \n 2- "+nomeProduto2+" \n 3- "+nomeProduto3+"\"Sem Cadastro\" \n Digite o produto: ");
                    int venda = int.Parse(Console.ReadLine());

                    if (venda == 1)
                    {
                        Console.WriteLine("Produto 1: " + nomeProduto1 + " - Estoque: " + quantidade1 + " - Valor: " + valor1);
                    }





                    //Console.WriteLine("Você escolheu VENDER UM PRODUTO");
                }
                else if (menu == 3)
                {
                    //Console.WriteLine("Você escolheu gerar UM RELATORIO DOS PRODUTOS");

                    Console.WriteLine("Bem vindo ao relatorio!!");
                    Console.WriteLine("Produto 1: " + nomeProduto1 + " - Estoque: " + quantidade1 + " - Valor: " + valor1);
                }
                else if (menu == 4)
                {
                    Console.Write("Digite uma frase: ");
                    string frase = Console.ReadLine();

                    Console.WriteLine(frase.ToUpper());
                    Console.WriteLine(frase.ToLower());
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
