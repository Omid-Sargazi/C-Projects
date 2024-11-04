namespace Vehicle
{
    public abstract class Vehicle:IVehicle
    {
        protected decimal BaseRate{get;}
        private readonly List<IRentalAddOn> _addOne = new List<IRentalAddOn>();

        protected Vehicle(decimal baseRate)
        {
            BaseRate=baseRate;
        }

        public void AddAddOn(IRentalAddOn addOn)
        {
            _addOne.Add(addOn);
        }

        public decimal CalculateTotalPrice(int duration)
        {
            decimal total = CalculateTotalPrice(duration);

            foreach(var addOn in _addOne)
            {
                total += addOn.GetCost(duration);
            }
            return total;
        }

        public abstract decimal CalculateBasePrice(int duration);

    }
}