using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
		public Car()
		{
		}

        public void Drive()
        {
            Console.WriteLine( "This car has four 18 inch tires.");
        }
    }
}

