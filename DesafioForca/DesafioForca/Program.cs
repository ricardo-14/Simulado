using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "CARRO";

            char[] palavraEscondida = new char[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                palavraEscondida[i] = '_';
            }

            while (Convert.ToString(palavraEscondida) != palavra)
            {
                Console.WriteLine("Digite uma letra: ");
                char letra = char.Parse(Console.ReadLine());

                bool letraCerta = false;

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        palavraEscondida[i] = letra;
                        letraCerta = true;
                    }
                }

                Console.WriteLine(palavraEscondida);

            }

            Console.WriteLine(palavraEscondida);
            Console.ReadKey();
        }
    }
}
