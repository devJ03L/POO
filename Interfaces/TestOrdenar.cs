namespace POO.Interfaces
{
    public class TestOrdenar
    {
        public static void Ejecutar()
        {
            Alumno[] arr = {
                new Alumno("Juan", 20, 8.5),
                new Alumno("Pedro", 18, 5.3),
                new Alumno("Alberto", 19, 4.6),
            };

            Util.Ordenar(arr, new CriterioAlumNombre());
            Array.ForEach(arr, x => Console.WriteLine(x));

            //Array de strings
            // string[] arrStr = { "Pablo", "Andres", "Marcelo" };
            // Util.Ordenar(arrStr);
            // Array.ForEach(arrStr, x => Console.WriteLine(x));

            //Array de int
            // int[] arrInt = new int[3];
            // arrInt[0] = 5; 
            // arrInt[1] = 3; 
            // arrInt[2] = 1; 
            // Util.Ordenar(arrInt);
            // Array.ForEach(arrInt, x => Console.WriteLine(x));
        }
    }
}