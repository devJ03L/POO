namespace POO.Figuras
{
    public class TestFiguras
    {
        public static void Ejecutar()
        {
            Circulo c = new Circulo(4);
            Rectangulo r = new Rectangulo(10, 5);
            Triangulo t = new Triangulo(3, 6);

            Console.WriteLine(c);
            Console.WriteLine(r);
            Console.WriteLine(t);
        }
    }
}