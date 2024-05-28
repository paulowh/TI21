using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_lacos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1- Do While \n2- For \n3- Switch Case \n4- Array \nEscolha uma opção: ");
            int menu = int.Parse(Console.ReadLine());
            Console.Clear();
            //Primeiro Exemplo: DO WHILE
            if (menu == 1)
            {
                //do
                //{
                // trecho de codigo
                //} while (true);

                int contador = 4;
                while (contador <= 3)
                {
                    Console.WriteLine("while: " + contador);
                    contador++;
                }
                // ele executa pelo menos uma vez o codigo
                do 
                {
                    Console.WriteLine("DO while: " + contador);
                    contador++;
                } while (contador <= 3);
                // do { codigo } while ( condicao ) 
            } 
            //Exemplo 2: utilizando o FOR
            else if (menu == 2)
            {
                //for (definição do contador; condição ; incremento){ codigo }
                for (int cont = 0; cont <3; cont++)
                {
                    Console.WriteLine("for: " + cont);
                }

            } 
            //Exemplo 3: utilizando o Switch
            else if (menu == 3)
            {

                Console.Write("Digite um valor: ");
                int condicao = int.Parse(Console.ReadLine());
                
                switch (condicao)
                {
                    case 0:
                        Console.WriteLine("Estou na condição 0");
                        break;

                    case 1:
                        Console.WriteLine("Estou na condição 1");
                        break;
                    case 2:
                        Console.WriteLine("Estou na condição 2");
                        break;
                    case 3:
                        Console.WriteLine("Estou na condição 3");
                        break;
                    case 4:
                        Console.WriteLine("Estou na condição 4");
                        break;
                    case 5:
                        Console.WriteLine("Estou na condição 5");
                        break;

                    default:
                        Console.WriteLine("Você escolheu uma opção invalida");
                        break;




                }


            }









            Console.Write("Press <enter> to continue...");
            Console.ReadKey();
        }
    }
}
