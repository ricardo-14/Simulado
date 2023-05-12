using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine().ToUpper();

            string palavraPalindromo = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {

                palavraPalindromo += palavra[i];

            }

            string resultado = palavraPalindromo == palavra ? "A string " + palavra + " é um palíndromo" : "A string " + palavra + " não é um palíndromo";

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
