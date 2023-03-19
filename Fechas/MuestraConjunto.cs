namespace POO.fechas
{
    public class MuestraConjunto
    {
        public static void mostrar(Object[] arr) =>        
            Array.ForEach(arr, x => Console.WriteLine(x.ToString()));        
    }
}