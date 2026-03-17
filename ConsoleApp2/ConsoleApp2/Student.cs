namespace ConsoleApp2;

public class Student : User
{
    public Student(Guid idUser, string name, string lastName) : base(idUser, name, lastName, UserType.Student)
    {
    }
}