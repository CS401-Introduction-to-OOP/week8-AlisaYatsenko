namespace Week8;

public class Letter : DeliveryItem
{
    public Letter ( string trackingnumber, double weight ) : base ( trackingnumber, weight )
    {}

    public override double CalculateCost()
    {
        var price = 15 + Weight*10;
        return price;
    }
}