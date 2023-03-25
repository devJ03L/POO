namespace POO.Figuras;
public abstract class FiguraGeometrica
{
    private string nombre;
    public FiguraGeometrica(string nomb) => nombre = nomb;
    public string getNombre() => nombre;
    public void setNombre(string nomb) => nombre = nomb;
    public abstract double Area();
    public override string ToString() => nombre + " (area = " + Area() + ")";
    public static double AreaPromedio(FiguraGeometrica[] arr)
    {
        double suma = 0;
        Array.ForEach(arr, fig => suma += fig.Area());
        return suma / arr.Count();
    }
}