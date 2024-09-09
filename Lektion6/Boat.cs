namespace Lektion6;

public class Boat : Vehicle
{
    public Boat(string brand, int year)
    //skicka vidasre till basklassen
    : base(brand, year)
    {

    }

    public override void StartEngine()
    {
        base.StartEngine();
        System.Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
}