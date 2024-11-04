namespace Vehicle
{
    public class ChildSeatAddOn:IRentalAddOn
    {
        public string Description => "Child Seat";

         public decimal GetCost(int duration)
         {
            return 20m; // Flat fee per rental
        }
    }
}