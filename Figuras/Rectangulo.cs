namespace POO.Figuras;
public class Rectangulo : FiguraGeometrica
{
    private double b;
    private double h;
    public Rectangulo(double b, double h) : base("Rectangulo")
    {
        this.b = b;
        this.h = h;
    }

    public override double Area() => b * h;
}