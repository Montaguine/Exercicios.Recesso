using ConversorCelciusFahrenheit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menus
{
    internal class MenuConversorTemperatura
    {
        public static void Menu()
        {
            Console.Clear();
            int opcao;
            do
            {
                double temperatura;
                Console.WriteLine("Selecione o tipo de conversão que deseja realizar");
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("\n0 - Retornar ao menu");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite a temperatura em Celsius");
                        temperatura = double.TryParse(Console.ReadLine(), out temperatura) ? temperatura : 0;
                        Console.WriteLine($"\n{temperatura}°c sao -> {ConversorTemperatura.ParaFahrenheit(temperatura).ToString("N2")}°F\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite a temperatura em Fahrenheit");
                        temperatura = double.TryParse(Console.ReadLine(), out temperatura) ? temperatura : 0;
                        Console.WriteLine($"\n{temperatura}°F sao -> {ConversorTemperatura.ParaCelsius(temperatura).ToString("N2")}°c\n");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
