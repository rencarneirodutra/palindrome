using System;
using System.Linq;

namespace Palindrome
{
     class Program
    {

        static void Main(string[] args)
        {
            resultado();
        }

        //Função de interação com o usuário
        public static void resultado()
        {
            Console.WriteLine("Digite algo: ");
            string palindromo = Console.ReadLine();

            bool res = checarPalindromo(palindromo);

            Console.WriteLine(res);

        }

        // Nesta função estamos usando o método Reverse() para inverter nossa string e compará-la com a string original usando o método SequenceEqual(). 
        public static bool checarPalindromo(string palindromo)
        {
            return palindromo.SequenceEqual(palindromo.Reverse());
        }


    }
}
