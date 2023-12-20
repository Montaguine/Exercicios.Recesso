namespace CalculadorFatorial
{
    public class CalculaFatorial
    {
        public static int Calcula(int numero)
        {
            int fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
