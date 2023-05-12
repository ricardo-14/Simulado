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
            string[] palavras = { "CARRO", "SAPATO", "BOLA" };

            Random randPalavra = new Random();

            string palavra = palavras[randPalavra.Next(palavras.Length)];

            char[] palavraEscondida = new char[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                palavraEscondida[i] = '_';
            }

            while (new string(palavraEscondida) != palavra)
            {
                Console.WriteLine("Digite uma letra: ");
                char letra = char.Parse(Console.ReadLine().ToUpper());

                bool letraCerta = false;

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        palavraEscondida[i] = letra;
                        letraCerta = true;
                    }
                
                }

                if (letraCerta == false) 
                {
                    Console.WriteLine("\nNão tem essa letra na palavra!");
                }

                Console.WriteLine(palavraEscondida);
            }

            Console.WriteLine("Parabéns você acertou a palavra!");
            Console.ReadKey();
        }
    }
}
