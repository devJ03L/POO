namespace POO.Interfaces
{
    public class Alumno// : IComparable
    {
        private string Nombre;
        private int Edad;
        private double NotaPromedio;
        public Alumno(string nom, int e, double np)
        {
            this.Nombre = nom;
            this.Edad = e;
            this.NotaPromedio = np;
        }
        //public int CompareTo(Alumno otroAlumno) => this.Edad - otroAlumno.Edad;
        public override string ToString() => Nombre + ", " + Edad + ", " + NotaPromedio;
        public void setNombre(string nom) => this.Nombre = nom;
        public void setEdad(int e) => this.Edad = e;
        public void setNotaPromedio(double np) => this.NotaPromedio = np;
        public string getNombre() => Nombre;
        public int getEdad() => Edad;
        public double getNotaPromedio() => NotaPromedio;
        // public int CompareTo(object? obj)
        // {
        //     if (obj == null) return 1;
        //     Alumno otroAlumno = (Alumno)obj;
        //     return this.Edad - otroAlumno.Edad;
        // }
    }
}