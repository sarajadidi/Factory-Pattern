﻿using System;
namespace FactoryPattern
{
	public class Truck : IVehicle
	{
		public Truck()
		{
		}

        public void Drive()
        {
            Console.WriteLine("This truck has four, 37 inch tires");
        }
    }
}

