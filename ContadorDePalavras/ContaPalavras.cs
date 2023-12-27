namespace ContadorDePalavras
{
    public class ContaPalavras
    {
        public static List<string> Agregador(string texto)
        {
            List<string> palavras = new List<string>();
            string palavra = "";
            foreach (char caracter in texto)
            {
                if (char.IsLetter(caracter))
                {
                    palavra += caracter;
                }
                else
                {
                    if (palavra != "")
                    {
                        palavras.Add(palavra);
                        palavra = "";
                    }
                }
            }
            if (palavra != "")
            {
                palavras.Add(palavra);
            }
            return palavras;
        }
        
        public static void Contador(List<string> palavras)
        {
            for(int i = 0; i < palavras.Count; i++)
            {
                int contador = 0;
                for(int j = 0; j < palavras.Count; j++)
                {
                    if (palavras[i] == palavras[j])
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"A palavra \"{palavras[i]}\" aparece {contador} vezes");
            }
        }
    }
}
