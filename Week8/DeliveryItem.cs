namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; set; }
    public double Weight { get; set; }

    public DeliveryItem(string trackingnumber, double weight)
    {
        TrackingNumber = trackingnumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($" TrackNumber : {TrackingNumber} | Weight : {Weight}");
    }
}