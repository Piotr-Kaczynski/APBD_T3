namespace ConsoleApp2;

public abstract class Equipment
{
    public Guid Id { get; set; }
    public string Name { set; get; }
    public EquipmentType Type { set; get; }
    public bool IsAvailable {set;get;}

    public Equipment(string name, EquipmentType type, bool isAvailable)
    {
        Id = Guid.NewGuid();
        Name = name;
        Type = type;
        IsAvailable = isAvailable;
    }
   
    
}

public enum EquipmentType
{
    Smartphone,
    Laptop,
    Camera
}