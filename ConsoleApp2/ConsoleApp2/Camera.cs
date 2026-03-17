namespace ConsoleApp2;

public class Camera : Equipment
{
    public int Resolution {set; get;}
    public double Zoom {set; get;}

    public Camera(string name, int resolution, double zoom)
        : base(name, EquipmentType.Camera, true)
    {
        Resolution = resolution;
        Zoom = zoom;
    }
    
    
}