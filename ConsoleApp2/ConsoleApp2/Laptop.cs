namespace ConsoleApp2;

public class Laptop : Equipment
{
    public string OperatingSystem { get; set; }
    public int RamGb { get; set; }
    
    public Laptop(string name, string os, int ramGb) 
        : base(name, EquipmentType.Laptop, true)
    {
        OperatingSystem = os;
        RamGb = ramGb;
    }
}