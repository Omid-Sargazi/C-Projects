namespace Vehicle
{
    public class WeeklyRental:IRentalDuration
    {
         public decimal GetPricePerDuration(decimal basePrice, int duration)
    {
        return basePrice * (duration / 7) * 0.85m; // 15% discount for weekly rentals
    }
    }
}