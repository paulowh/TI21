using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_repeticao
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1 - Contagem Crescente");
            Console.WriteLine("2 - Tabuada");
            Console.WriteLine("3 - Soma de Números");
            Console.WriteLine("4 - Adivinhar o Número");
            Console.Write("Escolha a opção: ");
            int menu = int.Parse(Console.ReadLine());

            Console.Clear();
            if (menu == 1)
            {
                int contador = 1;

                Console.Write("Digite um numero: ");
                int escolha_usuario = int.Parse(Console.ReadLine());


                while (contador <= escolha_usuario)
                {
                    Console.WriteLine(contador);
                    contador = contador + 1;
                }
            } else if (menu == 2)
            {
                int contador_tabuada = 1; //declaração de variaveis
                int escolha_tabuada_usuario;
                int total_multiplicacao_tabuada;

                Console.Write("Digite um numero para gerar a tabuada: "); //Comando para escrever o texto
                escolha_tabuada_usuario = int.Parse(Console.ReadLine()); //Comando para ler a resposta do usuario

                while(contador_tabuada <= 10)
                {
                    total_multiplicacao_tabuada = contador_tabuada * escolha_tabuada_usuario;

                    Console.WriteLine(escolha_tabuada_usuario + " x " + contador_tabuada + " = " + total_multiplicacao_tabuada);

                    contador_tabuada++;


                }
            } else if (menu == 3)
            {
                int escolha_soma_usuario;
                int contador_soma = 1;
                int soma_total = 0;

                Console.Write("Escolha quantos numeros você quer somar: ");
                escolha_soma_usuario = int.Parse(Console.ReadLine());

                while(contador_soma <= escolha_soma_usuario)
                {
                    Console.Write("Digite o " + contador_soma + "º numero: ");
                    soma_total += int.Parse(Console.ReadLine());


                    contador_soma++;
                }

                Console.WriteLine("O Valor total da soma foi: " + soma_total);

            } else if (menu == 4)
            {

                Random random = new Random();

                int numero_aleatorio = random.Next(1, 101);
                int tentativa_usuario = 0;
                
                while (tentativa_usuario != numero_aleatorio)
                {
                    Console.Write("Digite a tentativa: ");
                    tentativa_usuario = int.Parse(Console.ReadLine());

                    if(tentativa_usuario > numero_aleatorio)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; //mudo a cor das letras para a cor AZUL
                        Console.WriteLine("O numero digitado é MAIOR que o numero sorteado!");
                        
                    } else if (tentativa_usuario < numero_aleatorio)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //mudo a cor das letras para VERMELHO
                        Console.WriteLine("O numero digitado é MENOR que o numero sorteado!");
                    } else
                    {

                        Console.ForegroundColor = ConsoleColor.Green; //mudo a cor das letras para VERDE
                        Console.WriteLine("Parabens Você GANHOU !!!!");
                    }
                    Console.ResetColor(); //mudo a cor das letras para BRANCO
                    Console.WriteLine("");

                }


            }




            Console.ReadKey();
        }
    }
}
