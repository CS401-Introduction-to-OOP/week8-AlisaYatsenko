namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions { get ; private set ; }
    public Parcel ( string dimensions, string trackingnumber, double weight ) : base ( trackingnumber, weight )
    {
        this.Dimensions = dimensions;
    }
    public override void CalculateCost ()
    {
        var price = 50 + Weight*25;
        Console.WriteLine ($"Price : { price }");
    }
    public override void PrintInfo ()
    {
        base.PrintInfo () ;
        Console.WriteLine($"Dimensions : { Dimensions }");
    }
}