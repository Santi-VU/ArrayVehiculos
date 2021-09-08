using System;
using System.Collections.Generic;

namespace ArrayVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicable> vehicleList = AddData();

            //foreach (IVehicable v in vehicleList) {
            foreach (var v in vehicleList) // Variable var engloba todo tipo de variables, similar a JS.
            {
                v.VehicleInfo();
            }
        }

        public static List<IVehicable> AddData() {
            List<IVehicable> vehicleList = new List<IVehicable>();
            //List<IVehicable> vehicleList = new List<IVehicable>(9); -> Mejora de rendimiento

            vehicleList.Add(new Bike("Bicicleta", "Bh", "Bh1", 2, 'S', 21));
            vehicleList.Add(new Bike("Bicicleta", "Bh", "Bh2", 2, 'M', 24));
            vehicleList.Add(new Bike("Bicicleta", "Bh", "Bh3", 2, 'L', 27));
            vehicleList.Add(new Bike("Bicicleta", "Bh", "Triciclo", 3, 'S', 21));

            vehicleList.Add(new Car("Coche", "Renault", "Scenic", 4, 5, 192.300));
            vehicleList.Add(new Car("Coche", "Renault", "Clio", 4, 3, 210.000));
            vehicleList.Add(new Car("Coche", "Kia", "Río", 4, 5, 99.801));

            vehicleList.Add(new Scooter("Scooter", "Xiaomi", "Standar", 2, false, 231.5));
            vehicleList.Add(new Scooter("Scooter", "Xiaomi", "Pro", 2, false, 123));

            return vehicleList;
        }
    }
}
