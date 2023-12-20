namespace ConversorCelciusFahrenheit
{
    public class ConversorTemperatura
    {
        public static double ParaFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        public static double ParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

    }
}
