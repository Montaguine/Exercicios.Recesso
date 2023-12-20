using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrganizadorArray
{
    public class CriaArray
    {
        public static int[] Cria(int i)
        {
            int[] array = new int[i];
            Random random = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = RecebeValor();
            }
            return array;
        }
        private static int RecebeValor()
        {
            int numero;
            return int.TryParse(Console.ReadLine(), out numero) ? numero : 0; ;
        }

    }
}
