using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganizadorArray;

namespace UI.Menus
{
    internal class MenuOrganizaArray
    {
        public static void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o tamanho do array que deseja criar");
                int tamanho = int.TryParse(Console.ReadLine(), out tamanho) ? tamanho : 0;
                Console.WriteLine("Informe os valores para montar o array");
                int[] array = CriaArray.Cria(tamanho);
                Console.WriteLine("Array criado:");
                array.ToList().ForEach(x => Console.Write($"{x} "));
                Console.WriteLine("\nArray organizado:");
                array = OrganizaArray.OrganizaCrescente(array);
                array.ToList().ForEach(x => Console.Write($"{x} "));
                Console.WriteLine("\n\nDigite 0 para sair ou qualquer outro valor para continuar");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
