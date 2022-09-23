using System;
using System.Collections.Generic;

namespace Problema_de_Collatz
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciamento das variáveis e listas.
            int i, num;
            int maiorSeq;

            maiorSeq = 0;

            List<int> sequencias = new List<int>();
            List<int> maioresSeq = new List<int>();


            //Loop para o calculo do Problema de Collatz, é utilizada a lista "sequencias" para armazenamento das sequencias.
            for (i = 1; i <= 1000000; i++)
            {
                num = i;
                sequencias.Add(num);

                while (num > 1)
                {

                    if (num % 2 == 0)
                    {
                        num = num / 2;
                        sequencias.Add(num);

                    }
                    else
                    {
                        num = 3 * num + 1;
                        sequencias.Add(num);
                    }

                }

                //Condicional que compara os tamanhos das listas "sequencia" e "maioresSeq" para que se obtenhao número que gera a maior sequencia entre 1 e 1 milhão e armazena o mesmo na variável "maiorSeq".
                if (sequencias.Count > maioresSeq.Count)
                {
                    maioresSeq.Clear();
                    maiorSeq = i;
                    foreach (int x in sequencias)
                    {
                        maioresSeq.Add(x);
                    }
                }
                sequencias.Clear();
            }
            //Print do resultado
            Console.WriteLine($"O número que retorna a maior sequência entre 1 e 1 milhão é {maiorSeq}.");
        }
    }
}
