namespace Vehicle
{
    public class InsuranceAddOn:IRentalAddOn
    {
        public string Description => "Insurance";
        public decimal GetCost(int duration)
        {
            return 15m * duration; // $15 per day
        }
    }
}