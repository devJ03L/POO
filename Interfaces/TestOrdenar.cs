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

            // Util<Alumno>.Ordenar(arr, new CriterioAlumNombre());
            // Array.ForEach(arr, x => Console.WriteLine(x));

            // Util<Alumno>.Ordenar(arr, new CriterioAlumNotaProm());
            // Array.ForEach(arr, x => Console.WriteLine(x));

            int[] arrInt = { 10, 3, 7, 5, 4, 8, 2, 61, 736, 456 };
            Util<int>.Ordenar(arrInt, new CriterioInt());
            Array.ForEach(arrInt, x => Console.WriteLine(x));

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