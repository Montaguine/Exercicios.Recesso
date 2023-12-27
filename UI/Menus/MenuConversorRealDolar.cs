using ConversorRealDolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menus
{
    internal class MenuConversorRealDolar
    {
        public static void Menu()
        {
            Console.Clear();
            int opcao;
            Console.WriteLine("Para iniciar a calculadora de conversao, primeiro informe a cotação do Dólar");
            double cotacao = double.TryParse(Console.ReadLine(), out cotacao) ? cotacao : 0;
            do
            {
                Console.WriteLine("Informe a operacao que deseja realizar");
                Console.WriteLine("1 - Real para Dolar");
                Console.WriteLine("2 - Dolar para Real");
                Console.WriteLine("0 - Sair");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o valor em reais");
                        double real = double.TryParse(Console.ReadLine(), out real) ? real : 0;
                        Console.WriteLine($"O valor de {real} reais em dolar é {RealDolar.ParaDolar(real, cotacao)}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite o valor em dolar");
                        double dolar = double.TryParse(Console.ReadLine(), out dolar) ? dolar : 0;
                        Console.WriteLine($"O valor de {dolar} dolares em reais é {RealDolar.ParaReal(dolar, cotacao)}");
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }
    }
}
