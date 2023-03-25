namespace POO.Colecciones;
public class TestCola
{
    public static void Ejecutar()
    {
        MiCola<int> c = new MiCola<int>();
        c.encolar(1);
        c.encolar(2);
        c.encolar(3);

        Console.WriteLine(c.desencolar());
        Console.WriteLine(c.desencolar());

        c.encolar(4);

        Console.WriteLine(c.desencolar());
        Console.WriteLine(c.desencolar());
    }
}