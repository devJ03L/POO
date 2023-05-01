namespace POO.Tools;

public class Square
{
    public double Side { get; set; }
}

public class Circle
{
    public double Radius { get; set; }
}

public class Rectangle
{
    public double Height { get; set; }
    public double Length { get; set; }
}
public class Test
{
    public static double ComputedArea(object shape)
        => shape switch
        {
            Square s => s.Side * s.Side,
            Circle c => c.Radius * c.Radius * Math.PI,
            Rectangle r => r.Height * r.Length,
            _ => throw new ArgumentException(
                message: "Unrecognizable shape",
                paramName: nameof(shape))
        };
}