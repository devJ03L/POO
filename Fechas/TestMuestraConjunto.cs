namespace POO.fechas;
public class TestMuestraConjunto
{
    public static void Ejecutar()
    {
        Object[] arr = {
                new Fecha(2,10,1968),
                new FechaDetallada(2,10,1968),
                new String("Hola Sultan"),
                179
            };

        MuestraConjunto.mostrar(arr);
    }
}