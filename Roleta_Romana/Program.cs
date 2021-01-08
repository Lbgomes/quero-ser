using System;

namespace Roleta_Romana
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                --ROLETA ROMANA--
                https://dojopuzzles.com/problems/roleta-romana/
            */


            int pessoas = 5;
            int passo = 2;
            int inicio = 1;

            int count = 1;
            int proximo = inicio + passo;



            do
            {
                Console.WriteLine(proximo.ToString());


                proximo = proximo + passo;


                if (proximo > pessoas)
                {
                    proximo = proximo - pessoas;
                }

                count++;
            } while (count < pessoas);

        }
    }
}