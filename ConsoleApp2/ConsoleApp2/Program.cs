namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        var service = new RentalService();
        
        var cam = new Camera("Zenit c445", 42, 3.5);
        var laptop = new Laptop("Dell vostro", "Windows 11", 16);
        var phone = new Smartphone("iPhone 19", "IOS", 35900);
        
        var student = new Student(Guid.NewGuid(), "Tom", "Cruise");
        var employee = new Employee(Guid.NewGuid(), "Arthur", "Morgan");
        
        service.AddToInventory(cam);
        service.AddToInventory(laptop);
        service.AddToInventory(phone);
        
        Console.WriteLine("scenario #1: Correcr renting");
        
        service.Rent(student, cam, 5);
        service.Rent(employee, laptop, 14);
        service.Rent(employee, phone, 7);
        
        Console.WriteLine($"Rent {cam.Name} to user: {student.Name} {student.LastName}.");
        Console.WriteLine($"Rent {phone.Name} to user: {employee.Name} {employee.LastName}.");
        Console.WriteLine($"Rent {laptop.Name} to user: {employee.Name} {employee.LastName}.");
        
        Console.WriteLine("\nscenario #2: Unavailable equipment rent");
        try {
            service.Rent(employee, cam, 1);
        } catch (Exception e) {
            Console.WriteLine($"availability error: {e.Message}");
        }
        
        Console.WriteLine("\nscenario #3: Limit of rents exceeded");
        try {
            var secondCam = new Camera("Canon R6", 20, 1.5);
            var thirdCam = new Camera("Nikon Z6", 24, 1.8);
            
            service.AddToInventory(secondCam);
            service.AddToInventory(thirdCam);
    
            service.Rent(student, secondCam, 2);
            service.Rent(student, thirdCam, 2);
        } catch (Exception e) {
            Console.WriteLine($"limit error: {e.Message}");
        }
    }
}