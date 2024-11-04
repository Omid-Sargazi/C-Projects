namespace Vehicle
{
    public class Bike
    {
        public Bike(decimal baseRate):base(baseRate){}

        public override decimal CalculateBasePrice(int duration)
        {
            return BaseRate * duration * 0.8m;
        }
    }
}