using CalculaRaizQuadrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI.Menus
{
    internal class MenuCalculadoraRaizQuadrada
    {
        public static void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o numero que deseja calcular a raiz quadrada");
                double numero = double.TryParse(Console.ReadLine(), out numero) ? numero : 0;
                if(numero != 0 && numero > 0)
                {
                    Console.WriteLine($"A raiz quadrada de {numero} é {CalculaRaiz.RaizQuadrada(numero)}");
                } 

                else
                {
                    Console.WriteLine($"O numero {numero} nao possui raiz quadrada ");
                }
                Console.WriteLine("\n\nDigite 0 para sair ou qualquer outro valor para continuar");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
            } while (opcao != 0);
        }
    }
}
