namespace ConsoleApp2;

public class Employee : User
{
    public Employee(Guid idUser, string name, string lastName) : base(idUser, name, lastName, UserType.Employee)
    {
    }
}