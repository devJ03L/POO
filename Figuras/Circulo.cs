namespace POO.Figuras;
public class Circulo : FiguraGeometrica
{
    private int radio;
    public Circulo(int r) : base("Circulo") => radio = r;
    public override double Area() => Math.PI * Math.Pow(radio, 2);
}