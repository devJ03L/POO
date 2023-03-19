namespace POO.fechas
{
    public class TestFecha
    {
        public static void Ejecutar()
        {
            Fecha f = new Fecha(3, 12, 1999);
            Fecha f2 = new Fecha("26/11/2022");
            // f.setDia(2);
            // f.setMes(10);
            // f.setAnio(1970);

            // Console.WriteLine("Dia = " + f2.getDia());
            // Console.WriteLine("Mes = " + f2.getMes());
            // Console.WriteLine("Año = " + f2.getAnio());
            Console.WriteLine(f2);

            f2.addDias(4);
            Console.WriteLine(f2);

        }
    }
}