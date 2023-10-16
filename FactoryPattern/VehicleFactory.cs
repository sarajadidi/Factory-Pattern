using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		
		public static IVehicle GetVehicle(string carType)
		{
			switch (carType.ToLower())
			{
				case "car":
					return new Car();
				case "truck":
					return new Truck();
				default:
					return new Car();
			}
		}
	}
}

