namespace Vehicle
{
    public class GPSAddOn:IRentalAddOn
    {
        public string Description => "GPS";

        public decimal GetCost(int duration){
         return 5m * duration; // $5 per day
    }
    }
}