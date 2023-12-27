namespace ValidadorDeSenha
{
    public class Validador
    {
        public static string CriaSenha()
        {
            return Console.ReadLine();
        }

        public static bool ValidaSenha(string senha)
        {
            if (senha.Length < 8)
            {
                return false;
            }
            else
            {
                bool temNumero = false;
                bool temLetraMaiuscula = false;
                bool temLetraMinuscula = false;
                foreach (char caracter in senha)
                {
                    if (char.IsNumber(caracter))
                    {
                        temNumero = true;
                    }
                    if (char.IsUpper(caracter))
                    {
                        temLetraMaiuscula = true;
                    }
                    if (char.IsLower(caracter))
                    {
                        temLetraMinuscula = true;
                    }
                }
                if (temNumero && temLetraMaiuscula && temLetraMinuscula)
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
}
