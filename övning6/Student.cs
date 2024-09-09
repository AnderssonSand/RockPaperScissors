

public class Student
{
    public string? Name {get; set;}
    public int Grade {get; set;}

    //metod för om studenten är godkänd eller inte
    public void isPassing()
    {
        if (Grade >= 50)
        {
            Console.WriteLine("Student is passing.");
        }
        else
        {
            Console.WriteLine("Student is not passing.");
        }
    }

    //skapa en instans av  student
    

    public void displayStudentDetails()
    {
        Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        isPassing();
    }
}