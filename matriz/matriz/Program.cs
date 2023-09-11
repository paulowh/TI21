using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matriz = new string[11] { "pedro", "gui", "monique", "renon", "erick", "dany", "lucas", "gustavo", "samuel", "rafa", "edilson" };
            int[] idade = new int[11] { 17, 19, 68, 24, 17, 20, 20, 12, 22, 19, 5 };

            for (int contador = 0; contador < matriz.Length; contador++)
            {
                Console.WriteLine((contador + 1) + " - "+ matriz[contador]);
                Console.WriteLine(idade[contador]);
                Console.WriteLine("");
            }

            Console.Write("Escolha um produto: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.WriteLine(matriz[escolha - 1]);

            Console.ReadKey();

        }
    }
}
