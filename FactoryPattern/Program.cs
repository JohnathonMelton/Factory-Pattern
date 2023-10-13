namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            Console.WriteLine();
            Console.Write("Options: 2 or 4. Choice made:");

            var userInput = Convert.ToInt32(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);

            IVehicle motorcycle = VehicleFactory.GetVehicle(2);
            IVehicle truck = VehicleFactory.GetVehicle(4);

            if (userInput == 2)
            {
                Console.WriteLine("You have chosen a motorcycle.");
            }
            else if (userInput == 4) 
            {
                Console.WriteLine("You have chosen a truck.");
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }

            
        }
    }
}
