namespace POO.fechas;
public class TestFechaDetallada
{
    public static void Ejecutar()
    {
        FechaDetallada f = new FechaDetallada();

        f.setDia(25);
        f.setMes(10);
        f.setAnio(2009);

        Console.WriteLine(f);
    }
}