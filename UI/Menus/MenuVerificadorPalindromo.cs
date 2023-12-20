using VerificadorPalindromo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menus
{
    internal class MenuVerificadorPalindromo
    {
        public static void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a palavra que deseja verificar");
                string? palavra = Console.ReadLine();
                Console.WriteLine($"A palavra {palavra} {(VerificaPalindromo.Palindromo(palavra) ? "É" : "NÃO é")} um palindromo");
                Console.WriteLine("\nDigite 0 para sair ou qualquer outro valor para continuar");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
