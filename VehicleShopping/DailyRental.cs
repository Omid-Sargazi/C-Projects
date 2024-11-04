namespace Vehicle
{
    public class DailyRental:IRentalDuration
    {
        public decimal GetPricePerDuration(decimal basePrice, int duration)
        {
            decimal total = basePrice * duration;
            if (duration > 7)
        {
            total *= 0.9m; // 10% discount for rentals over a week
        }
            return total;
        }
    }
}