﻿using CalculadorFatorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Menus
{
    internal class MenuCalculaFatorial
    {
        public static void Menu()
        {
            int numero;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite um numero para calcular seu fatorial");
                numero = int.TryParse(Console.ReadLine(), out numero) ? numero : 0;
                Console.WriteLine($"O fatorial de {numero} é {CalculaFatorial.Calcula(numero)}");
                Console.WriteLine("Digite 0 para sair ou qualquer outro valor para continuar");
                numero = int.TryParse(Console.ReadLine(), out numero) ? numero : 0;
            } while (numero != 0);
        }
    }
}
