using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorDeSenha;

namespace UI.Menus
{
    internal class MenuValidadorDeSenha
    {
        public static void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha que deseja validar");
                string senha = Validador.CriaSenha();
                if (Validador.ValidaSenha(senha))
                {
                    Console.WriteLine("Senha valida");
                }
                else
                {
                    Console.WriteLine("Senha invalida");
                }
                Console.WriteLine("\n\nDigite 0 para sair ou qualquer outro valor para continuar");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
