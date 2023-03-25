namespace POO.Colecciones;
public class TestPila
{
    public static void Ejecutar()
    {
        MiPila<int> c = new MiPila<int>();
        c.apilar(1);
        c.apilar(2);
        c.apilar(3);

        Console.WriteLine(c.desapilar());
        Console.WriteLine(c.desapilar());

        c.apilar(4);

        Console.WriteLine(c.desapilar());
        Console.WriteLine(c.desapilar());
    }
}