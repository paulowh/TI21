using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_For_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1- Números Pares no Intervalo \n2- Sequência de Fibonacci \n3- Números Primos no Intervalo \nEscolha uma opção: ");
            int menu = int.Parse(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.WriteLine("Você escolheu \"Números Pares no Intervalo\"");
                    int numero1, numero2;

                    Console.Write("Escolha o numero inicial: ");
                    numero1 = int.Parse(Console.ReadLine());

                    Console.Write("Escolha o numero final: ");
                    numero2 = int.Parse(Console.ReadLine());

                    for (int contador = numero1; contador <= numero2; contador++)
                    {
                        if (contador % 2 == 0)
                        {
                            Console.WriteLine("Numero atual: " + contador);
                        }
                    }

                    break;
                case 2:
                    Console.WriteLine("Você escolheu \"Sequência de Fibonacci\"");

                    Console.Write("Digite a posição escolhida: ");
                    int posicao = int.Parse(Console.ReadLine());
                    int anterior = 0, atual = 1, temporario = 0;

                    //A recebe o valor de B, B recebe de C e C recebe de A + B 
                    //Console.WriteLine("O valor de C: " + (a + b)); 

                    for (int contador = 0; contador < posicao; contador++)
                    {
                        Console.WriteLine("Fibonacci posição " + (contador + 1) + ": " + (atual));

                        temporario = anterior;
                        anterior = atual;
                        atual = temporario + atual;
                    }
                    break;
                case 3:
                    Console.WriteLine("Você escolheu \"Números Primos no Intervalo\"");
                    Console.Write("Digite um numero: ");
                    int valor = int.Parse( Console.ReadLine());

                    for (int contador = 2; contador <= valor; contador++)
                    {
                        bool primo = true;
                        for (int j = 2; j < contador; j++)
                        {
                            if (contador % j == 0)
                            {
                                primo = false;
                            }
                        }
                        if (primo)
                        {
                            Console.WriteLine("O numero: " + contador + " é PRIMO");
                        }
                    }break;
                default:
                    Console.WriteLine("IRMÃO ESCOLHE UMA OPÇÃO VALIDA AI!!!");
                    break;

            }


            Console.Write("\n\npress <enter> to continue....");
            Console.ReadKey();
        }
    }
}
