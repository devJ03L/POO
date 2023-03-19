
namespace POO.fechas
{
    public class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

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
        public int getDia() => dia;
        public void setDia(int dia) => this.dia = dia;
        public int getMes() => mes;
        public void setMes(int mes) => this.mes = mes;
        public int getAnio() => anio;
        public void setAnio(int anio) => this.anio = anio;

        public override string ToString() => dia + "/" + mes + "/" + anio;
        private int fechaToDias() => anio * 360 + mes * 30 + dia;
        private void diasToFecha(int i)
        {
            anio = (int)i/ 360;

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

        public void addDias (int d)
        {
            int sum = fechaToDias() + d;
            diasToFecha(sum);
        }
    }
}