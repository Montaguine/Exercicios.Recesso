namespace VerificadorNumerosPrimos
{
    public class VerificadorPrimos
    {
        public static bool VerificaPrimo(int numero)
        {
            int contador = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    contador++;
            }
            if (contador == 2)
                return true;
            else
                return false;
        }
    }
}
