namespace ConsoleApp2;

public class Smartphone : Equipment
{
    public string OperatingSystem { get; set; }
    public int BatteryCapacity { get; set; }
    
    public Smartphone(string name, string os, int battery) 
        : base(name, EquipmentType.Smartphone, true)
    {
        OperatingSystem = os;
        BatteryCapacity = battery;
    }
}