namespace Lektion6;

// public class Vehicle
// {

    
public class Vehicle
{
  
    //Publika fält
    // private string? _brand;
    // private int _year;

protected string Brand { get; set; }
protected int Year { get; set; }   

    // //Konstruktor, initierar fordonets attribut

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public string getBrand()
    {
       return Brand;
       
    }

    public void SetBrand(string value)
    {
        Brand = value;
        
    }

    public int GetYear()
    {
        return Year;
    }

    public void SetYear(int value)
    {
  
        Year = value;  
    }

    
    public virtual void StartEngine()
    {
        System.Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
 
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }







}
