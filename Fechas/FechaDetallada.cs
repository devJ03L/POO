namespace POO.fechas;
public class FechaDetallada : Fecha
{
    private static String[] meses = {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviemre",
            "Diciembre"
        };
    public FechaDetallada() : this(0, 0, 0) { }
    public FechaDetallada(string s) : base(s) { }
    public FechaDetallada(int d, int m, int a) : base(d, m, a) { }

    public override string ToString() =>
        dia + " de " + meses[mes - 1] + " de " + anio;

}