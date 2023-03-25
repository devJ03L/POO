namespace POO.fechas;
public class FechaHora : FechaDetallada
{
    private int hora;
    private int minuto;
    private int segundo;

    public FechaHora(string sFecha, int hora, int minuto, int segundo) : base(sFecha)
    {
        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
    }

    public override string ToString() =>
        base.ToString() + " (" + hora + ":" + minuto + ":" + segundo + ")";
}