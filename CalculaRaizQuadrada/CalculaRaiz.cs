namespace CalculaRaizQuadrada
{
    public class CalculaRaiz
    {
        public static double Raiz(double numero)
        {
            var contador = 0;
            double raiz = 0;
            for (double i = 0; i <= numero; i++)
            {
                if(i * i == numero)
                {
                    return raiz = i;
                }
                if(i * i > numero)
                {
                    i = i - 1;
                    double j = i;
                    double complemento = 5;
                    double decimais = 10;
                    double passo;
                    do
                    {
                        passo = complemento / decimais;
                        if((j + passo) * (j + passo) < numero)
                        {
                            complemento++;
                            passo = complemento / decimais;
                            if((j + passo) * (j + passo) > numero)
                            {
                                complemento--;
                                passo = complemento / decimais;
                                j = j + passo;
                                decimais = decimais * 10;
                                complemento = 5;
                            }
                        }
                        if((j + passo) * (j + passo) > numero)
                        {
                            complemento--;
                            passo = complemento / decimais;
                            if ((j + passo) * (j + passo) < numero)
                            {
                                passo = complemento / decimais;
                                j = j + passo;
                                decimais = decimais * 10;
                                complemento = 5;
                            }
                        }
                        if((j + passo) * (j + passo) == numero)
                        {
                            i = j + passo;
                        }
                        if(decimais > 1000000000000)
                        {
                            return i = j + passo;
                        }
                    } while (i * i != numero);
                }
            }
            return 0;
        }
    }

}
