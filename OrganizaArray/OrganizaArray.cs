namespace OrganizadorArray
{
    public class OrganizaArray
    {
        public static int[] OrganizaCrescente(int[] array)
        {
            int[] arrayOrdenado = new int[array.Length];
            int aux = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arrayOrdenado[i] = array[i];
            }
            for (int i = 0; i < arrayOrdenado.Length; i++)
            {
                for (int j = 0; j < arrayOrdenado.Length; j++)
                {
                    if (arrayOrdenado[i] < arrayOrdenado[j])
                    {
                        aux = arrayOrdenado[i];
                        arrayOrdenado[i] = arrayOrdenado[j];
                        arrayOrdenado[j] = aux;
                    }
                }
            }
            return arrayOrdenado;
        }
    }
}
