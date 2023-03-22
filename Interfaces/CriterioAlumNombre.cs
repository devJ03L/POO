namespace POO.Interfaces
{
    public class CriterioAlumNombre : Criterio<Alumno>
    {
        public CriterioAlumNombre():base(){}
        public override int comparar(Alumno a, Alumno b) => 
            a.getNombre().CompareTo(b.getNombre());
    }
}