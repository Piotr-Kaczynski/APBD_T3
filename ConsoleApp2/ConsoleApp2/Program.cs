namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        var service = new RentalService();
        var cam = new Camera("Zenit c445", 42, 3.5);
        var laptop = new Laptop("Dell vostro", "Windows 11", 16);
        var student = new Student(Guid.NewGuid(), "Tom", "Cruise");
        
        
        service.AddToInventory(cam);
        service.AddToInventory(laptop);

        Console.WriteLine("scenario #1: Correcr renting");
        service.Rent(student, cam, 5);
        Console.WriteLine($"Rent {cam.Name} to user: {student.Name} {student.LastName}.");
        
    }
}