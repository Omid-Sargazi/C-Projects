namespace Vehicle
{
    public class Truck:Vehicle
    {
        public Truck(decimal baseRate):base(baseRate){}

        public override decimal CalculateBasePrice(int duration)
        {
            return BaseRate * duration * 1.5m;
        }
    }
}