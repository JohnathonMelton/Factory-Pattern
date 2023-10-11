namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle motorcycle = VehicleFactory.GetVehicle(2);
            IVehicle truck = VehicleFactory.GetVehicle(4);
        }
    }
}
