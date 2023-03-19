namespace POO.fechas
{
    public class TestPolimorfismo
    {
        public static void Ejecutar()
        {
            Fecha f = new FechaDetallada(19,6,1990);
            Object obj = new FechaDetallada(20,6,1993);
            
            Console.WriteLine(f);
            Console.WriteLine(obj);
        }
    }
}