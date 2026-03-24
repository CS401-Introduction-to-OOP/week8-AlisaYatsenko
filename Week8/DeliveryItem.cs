namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    public double Weight { get; }

    public DeliveryItem(string trackingnumber, double weight)
    {
        this.TrackingNumber = trackingnumber;
        this.Weight = weight;
    }

    public abstract void CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($" TrackNumber : {TrackingNumber} | Weight : {Weight}");
    }
}