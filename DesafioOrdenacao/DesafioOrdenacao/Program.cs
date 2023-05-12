using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;

            int[] numeros = { 1, 5, 3, 8, 2, 9, 10, 7, 4, 6 };

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];

                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }

            Console.WriteLine("Números ordenados: ");
            for (int i = 0;i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+", " );
            }
            Console.ReadKey();
        }
    }
}
