namespace Vehicle
{
    public interface IRentalDuration
    {
        decimal GetPricePerDuration(decimal basePrice, int duration);
    }
}