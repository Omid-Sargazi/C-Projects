namespace Vehicle
{
    public interface IRentalAddOn
    {
        decimal GetCost(int duration);
        string Description{get;}
    }
}