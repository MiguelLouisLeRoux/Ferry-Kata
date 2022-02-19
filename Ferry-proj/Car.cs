public class Car
{
    public string Colour { get; }
    public int PassangerCount { get; }
    public Car (string colour, int passangerCount)
    {
        Colour = colour;
        PassangerCount = passangerCount;
    }

    //car_id attribute and method is used to keep track of particular cars and identifying whether it qualifies for discounts
    public int car_id { get; set; }

    public int ferryTripsCount { get; set; }

}