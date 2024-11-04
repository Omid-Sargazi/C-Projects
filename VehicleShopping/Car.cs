namespace Vehicle
{
    public class Car:Vehicle
    {
        public Car(decimal baseRate):base(baseRate){}

        public override decimal CalculateBasePrice(int duration)
        {
            return BaseRate * duration;
        }
    }
}