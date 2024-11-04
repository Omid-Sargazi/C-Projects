namespace Vehicle
{
    public class HourlyRental:IRentalDuration
    {
        public decimal GetPricePerDuration(decimal basePrice, int duration)
        {
            return basePrice * duration;
        }
    }
}