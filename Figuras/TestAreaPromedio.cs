namespace POO.Figuras
{
    public class TestAreaPromedio
    {
        public static void Ejecutar()
        {
            FiguraGeometrica[] arr = {
                new Circulo(23),
                new Rectangulo(12, 4),
                new Triangulo(2, 5)
            };

            double prom = FiguraGeometrica.AreaPromedio(arr);
            Console.WriteLine(prom);
        }
    }
}