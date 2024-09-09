namespace Lektion6;


public class Car : Vehicle
{
    private int _numberOfDoors;

    public Car(string brand, int year, int numberOfDoors) 
    : base(brand, year)
    {
        _numberOfDoors = numberOfDoors;
    }

    //getters och setters för numberOfDoors

    public int GetNumberOfDoors
    {
        get {return _numberOfDoors;} 
        set 
        {
            if (value > 0)
            {
                _numberOfDoors = value;
            }
        }
    }




     public override void StartEngine()
    {
        Console.WriteLine($"{Brand}Engine started");
     }

}