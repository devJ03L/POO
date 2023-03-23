namespace POO.Interfaces
{
    public class Util<T>
    {
        public static void Ordenar(T[] arr, Criterio<T> cr)
        {
            bool ordenado = false;
            while (!ordenado)
            {
                ordenado = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (cr.comparar(arr[i + 1], arr[i]) < 0)
                    {
                        T aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        ordenado = false;
                    }
                }
            }
        }
    }
}