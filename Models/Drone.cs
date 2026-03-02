namespace DroneATC.Models;

public class Drone
{
    public int Id { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Altitude { get; set; }
    public double Speed { get; set; }

    public Drone(int id, double x, double y, double altitude, double speed)
    {
        Id = id;
        X = x;
        Y = y;
        Altitude = altitude;
        Speed = speed;
    }

    
}
