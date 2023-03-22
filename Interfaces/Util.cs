namespace POO.Interfaces
{
    public class Util
    {
        public static void Ordenar(object[] arr, Criterio cr)
        {
            bool ordenado = false;
            while (!ordenado)
            {
                ordenado = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (cr.comparar(arr[i + 1], arr[i]) < 0)
                    {
                        object aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        ordenado = false;
                    }
                }
            }
        }
    }
}