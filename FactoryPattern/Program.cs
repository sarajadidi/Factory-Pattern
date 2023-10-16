namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of car do you have?");
            var carType = Console.ReadLine();

            var car = VehicleFactory.GetVehicle(carType);
            car.Drive();
        }
    }
}
