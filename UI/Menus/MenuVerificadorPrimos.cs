using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificadorNumerosPrimos;

namespace UI.Menus
{
    internal class MenuVerificadorPrimos
    {
        public static void Menu()
        {
            Console.Clear();
            int opcao;
            do
            {
                int numero;
                Console.WriteLine("Digite o numero que deseja verificar");
                numero = int.TryParse(Console.ReadLine(), out numero) ? numero : 0;
                Console.WriteLine($"\nO numero {numero} é primo? -> {VerificadorPrimos.VerificaPrimo(numero)}\n");
                Console.WriteLine("Deseja verificar outro numero?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("\n0 - Não");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
