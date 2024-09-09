using System.Runtime.InteropServices;

namespace Lektion6;

class Program
{
    static void Main(string[] args)
    {

        Vehicle myCar = new Car("Volvo", 2021, 4);
        Vehicle myBoat = new Boat ("Buster", 2021);

        myCar.StartEngine();
        myBoat.StartEngine();

        myCar.DisplayInfo();







        // Car myCar = new("Volvo", 2021, 6);

        // myCar.StartEngine();

        // System.Console.WriteLine(myCar.GetNumberOfDoors = 4);

        // myCar.SetBrand("fiat");

        // myCar.DisplayInfo();

        // Console.WriteLine(myCar.GetYear());

        // Console.WriteLine(myCar.Year);

        //Objektorienterad programmering 
        //Klasser och objekt

        //Skapa ett objekt av klassen Vehicle
        // Vehicle myVehicle = new("volvo", 2021, 4);

        // myVehicle.DisplayInfo();

        // System.Console.WriteLine(myVehicle.Brand);

        // myVehicle.Year = 2016;

        // //Sätt värden på objektets fält
        // // myVehicle.SetBrand("Volvo");
        // // myVehicle.SetYear(2021);

        // //Anropa metoden DisplayInfo på objektet
        // myVehicle.DisplayInfo(myVehicle.Brand, myVehicle.Year);
         


    }
}
