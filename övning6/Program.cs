namespace övning6
{
    using System;
    using System.Runtime.InteropServices;

    public class Program
    {
        //Fråga Victor om dehär:
        //The code works because the Price property is an int, 
        //and the discountPercentage parameter in the getDiscountedPrice method is a double. 
        //When you perform arithmetic operations between an int and a double, the int is implicitly converted 
        //to a double for the calculation. This allows the code to handle the discount calculation correctly.
        public static void Main(string[] args)
        {
            // Book myBook = new Book();

            // myBook.Title = "Twilight";
            // myBook.Price = 279;

            // myBook.displayBookDetails();

            // Console.WriteLine("Percentage of discount? e.g. '10', '20', '30'.");
            // int discountInput = Convert.ToInt32(Console.ReadLine());

            // myBook.getDiscountedPrice(discountInput);

            //Skapa instans av student för att skapa ett minvärde för Grade
            // Student myStudent = new Student();
            // myStudent.Name = "Tanja";

            // System.Console.WriteLine("What is your grade?");
            // myStudent.Grade = Convert.ToInt32(Console.ReadLine());

            // myStudent.displayStudentDetails();

            //SKapa en instans av circle

            Circle myCircle = new Circle();
            System.Console.WriteLine("Please enter radius of the circle?");
            myCircle.Radius = Convert.ToDouble(Console.ReadLine());
            myCircle.displayCircleDetails();

        }
    }
}