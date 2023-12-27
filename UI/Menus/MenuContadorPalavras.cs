using ContadorDePalavras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menus
{
    internal class MenuContadorPalavras
    {
        public static void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a frase que deseja contar as palavras");
                string frase = Console.ReadLine();
                ContaPalavras.Contador(ContaPalavras.Agregador(frase));
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
