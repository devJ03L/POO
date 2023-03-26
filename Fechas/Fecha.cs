namespace POO.fechas;
public class Fecha
{
    public int dia
    {
        get => dia;
        set => dia = value;
    }
    public int mes
    {
        get => mes;
        set => mes = value;
    }
    public int anio
    {
        get => anio;
        set => anio = value;
    }
    public Fecha() { }
    public Fecha(int d, int m, int a)
    {
        dia = d;
        mes = m;
        anio = a;
    }
    public Fecha(String s)
    {
        int pos1 = s.IndexOf('/');
        int pos2 = s.LastIndexOf('/');

        String sDia = s.Substring(0, pos1);
        dia = int.Parse(sDia);

        String sMes = s.Substring(pos1 + 1, 2);
        mes = int.Parse(sMes);

        String sAnio = s.Substring(pos2 + 1);
        anio = int.Parse(sAnio);
    }
    public override string ToString() => dia + "/" + mes + "/" + anio;
    private int fechaToDias() => anio * 360 + mes * 30 + dia;
    private void diasToFecha(int i)
    {
        anio = (int)i / 360;

        int resto = i % 360;

        mes = (int)resto / 30;

        dia = resto % 30;

        if (dia == 0)
        {
            dia = 30;
            mes--;
        }

        if (mes == 0)
        {
            mes = 12;
            anio--;
        }
    }

    public void addDias(int d)
    {
        int sum = fechaToDias() + d;
        diasToFecha(sum);
    }
}