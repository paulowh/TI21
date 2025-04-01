using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aluno1 = "erick";
            string aluno2 = "renon";
            string aluno3 = "samuel";
            string aluno4 = "gustavo";

            string prof1 = "paulo";
            string prof2 = "vagner";
            string prof3 = "ricardo";

            string[] alunos = { "erick", "renon", "samuel", "gustavo", "lucas" };
            string[] profs = { "paulo", "vagner", "ricardo" };

            float[] idades = { 17, 25, 19, 19, 18, 29 };

            //Erick
            float media = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                media += idades[i];
            }
            media = media / idades.Length;
            Console.WriteLine(media);

            //Pedrin
            float sum = 0;
            Array.ForEach(idades, contador => sum += contador);
            sum = sum / idades.Length;
            Console.WriteLine(sum);

            //Paulin
            float total = idades.Sum() / idades.Length;
            Console.WriteLine(total);

       
            foreach(var meubb in alunos)
            {
                if (meubb == "erick")
                {
                    foreach(var letra in meubb)
                    {
                        Console.WriteLine(letra);
                    }

                }
                else
                {
                    Console.WriteLine(meubb);
                }



                /*if(meubb == "gustavo")
                {
                    Console.WriteLine("Vulgo MALVADÃO");
                } else if (meubb == "erick")
                {
                    Console.WriteLine("Vulgo c# de Mél");
                } else
                {
                    Console.WriteLine(meubb);
                }*/

            }

            foreach (var aqui_e_uma_variavel_qualquer in "BOM DIA MEUS BB")
            {
                Console.WriteLine(aqui_e_uma_variavel_qualquer);
            }

            

            Console.ReadKey();
        }
    }
}
