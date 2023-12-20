namespace VerificadorPalindromo
{
    public class VerificaPalindromo
    {
        public static bool Palindromo(string palavra)
        {
            palavra = palavra.ToLower();
            string palavraInvertida = "";
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }
            return palavraInvertida == palavra;
        }
    }
}
