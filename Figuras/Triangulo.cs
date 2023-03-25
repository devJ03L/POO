namespace POO.Figuras;
public class Triangulo : FiguraGeometrica
{
    private double b;
    private double h;
    public Triangulo(double b, double h) : base("Triangulo")
    {
        this.b = b;
        this.h = h;
    }
    public override double Area() => b * h / 2;
}