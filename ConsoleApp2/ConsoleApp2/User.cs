namespace ConsoleApp2;

public abstract class User
{
    public Guid IdUser { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public UserType Type { get; set; }

    public User(Guid idUser, string name, string lastName, UserType type)
    {
        IdUser = idUser;
        Name = name;
        LastName = lastName;
        Type = type;
        
    }

}

public enum UserType
{
    Employee,
    Student
}