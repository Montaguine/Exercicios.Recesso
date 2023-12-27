namespace ConversorRealDolar
{
    public class RealDolar
    {
        public static double ParaDolar(double real, double cotacao)
        {
            return real / cotacao;
        }

        public static double ParaReal(double dolar, double cotacao)
        {
            return dolar * cotacao;
        }
    }
}
