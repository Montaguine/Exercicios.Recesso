using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorCPF;

namespace UI.Menus
{
    internal class MenuValidadorCPF
    {
        public static void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o CPF que deseja validar");
                string? cpf = Console.ReadLine();
                if (ValidaCPF.Valida(cpf))
                {
                    Console.WriteLine("CPF valido");
                }
                else
                {
                    Console.WriteLine("CPF invalido");
                }
                Console.WriteLine("\n\nDigite 0 para sair ou qualquer outro valor para continuar");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
