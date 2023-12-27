namespace ValidadorCPF
{
    public class ValidaCPF
    {
        public static bool Valida(string? cpf)
        {
            int[] cpfArray = new int[11];
            int[] multiplicador = new int[11];
            int soma = 0;
            int resto = 0;
            int digito1 = 0;
            int digito2 = 0;
            int contador = 0;
            foreach (char caracter in cpf)
            {
                if (char.IsNumber(caracter))
                {
                    cpfArray[contador] = int.Parse(caracter.ToString());
                    contador++;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                multiplicador[i] = 10 - i;
                soma += cpfArray[i] * multiplicador[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                multiplicador[i] = 11 - i;
                soma += cpfArray[i] * multiplicador[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (digito1 == cpfArray[9] && digito2 == cpfArray[10])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
