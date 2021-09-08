using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayVehiculos
{
    internal class Car : Vehicle, IVehicable
    {   
        public int doors { get; protected set; }
        public double km { get; protected set; }

        public Car() {
            this.type = "";
            this.mark = "";
            this.model = "";
            this.wheels = -1;
            this.doors = -1;
            this.km = -1;
        }

        public Car(string type, string mark, string model, int wheels, int doors, double km)
        {
            this.type = type;
            this.mark = mark;
            this.model = model;
            this.wheels = wheels;
            this.doors = doors;
            this.km = km;
        }

        public void VehicleType()
        {
            Console.WriteLine("Tipo: " + this.type);
        }

        public void VehicleInfo()
        {
            VehicleType();
            Console.WriteLine("\t" + "Marca: " + this.mark + " " + this.model + "\n" + 
                              "\t" + "Puertas: " + this.doors.ToString() + ", Kilometros: " + this.km.ToString());
        }
    }
}
