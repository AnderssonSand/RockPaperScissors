

public class Circle
{
    public double Radius { get; set; }

    public double getArea()
    {
        return 3.14 * Radius * Radius;

    }

    public double getPerimeter()
    {

        return 2 * Math.PI * Radius;
    }

    public void displayCircleDetails()
    {
        Console.WriteLine($"Area: {getArea()}");
        Console.WriteLine($"Perimeter: {getPerimeter()}");
    }
}