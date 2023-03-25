namespace POO.Interfaces;
public class CriterioAlumNotaProm : Criterio<Alumno>
{
    public override int comparar(Alumno a, Alumno b) =>
        a.getNotaPromedio().CompareTo(b.getNotaPromedio());
}