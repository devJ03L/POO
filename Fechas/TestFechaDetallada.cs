namespace POO.fechas;
public class TestFechaDetallada
{
    public static void Ejecutar()
    {
        FechaDetallada f = new FechaDetallada();

        f.dia = 25;
        f.mes = 10;
        f.anio = 2009;

        Console.WriteLine(f);
    }
}