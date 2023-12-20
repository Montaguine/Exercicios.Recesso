using ConversorCelciusFahrenheit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Menus;

namespace UI
{
    internal class GeraMenu
    {
        public static void MenuExercicios()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione o exercicio que deseja visualizar\n");
                Console.WriteLine("1 - Conversor de temperatura Fahrenheit x Celcius");
                Console.WriteLine("2 - Verificador numeros primos");
                Console.WriteLine("3 - Fatorial");
                Console.WriteLine("4 - Organizador crescente de array");
                Console.WriteLine("5 - Verificador de palindromo");
                Console.WriteLine("6 - Calculadora de raiz quadrada");
                Console.WriteLine("7 - Conversor de Real para Dolar");
                Console.WriteLine("8 - Criador e verificador de senha");
                Console.WriteLine("9 - Validador de CPF");
                Console.WriteLine("10 - Contador de palavras");
                Console.WriteLine("\n0 - Sair");
                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;

                switch (opcao)
                {
                    case 1:
                        MenuConversorTemperatura.Menu();
                        break;
                    case 2:
                        MenuVerificadorPrimos.Menu();
                        break;
                    case 3:
                        MenuCalculaFatorial.Menu();
                        break;
                    /*                case 4:
                                        MenuOrganizadorCrescente();
                                        break;
                                    case 5:
                                        MenuVerificadorPalindromo();
                                        break;
                                    case 6:
                                        MenuCalculadoraRaizQuadrada();
                                        break;
                                    case 7:
                                        MenuConversorRealDolar();
                                        break;
                                    case 8:
                                        MenuCriadorVerificadorSenha();
                                        break;
                                    case 9:
                                        MenuValidadorCPF();
                                        break;
                                    case 10:
                                        MenuContadorPalavras();
                                        break;
                    */
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
