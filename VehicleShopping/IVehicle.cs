namespace Vehicle
{
  public interface IVehicle
  {
    decimal CalculateBasePrice(int duration);
    void AddAddOn(IRentalAddOn addOn);
    decimal CalculateTotalPrice(int duration);
  }  
} 