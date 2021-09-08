using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayVehiculos
{
    internal class Bike : Vehicle, IVehicable
    {   
        public char size { get; protected set; }
        public int wheelSize { get; protected set; }

        public Bike() {
            this.type = "";
            this.mark = "";
            this.model = "";
            this.wheels = -1;
            this.size = ' ';
            this.wheelSize = -1;
        }

        public Bike(string type, string mark, string model, int wheels, char size, int wheelSize)
        {
            this.type = type;
            this.mark = mark;
            this.model = model;
            this.wheels = wheels;
            this.size = size;
            this.wheelSize = wheelSize;
        }

        public void VehicleType()
        {
            Console.WriteLine("Tipo: " + this.type);
        }

        public void VehicleInfo()
        {
            VehicleType();
            Console.WriteLine("\t" + "Marca: " + this.mark + " " + this.model + "\n" +
                              "\t" + "Talla: " + this.size + ", Pulgadas ruedas: " + this.wheelSize.ToString());
        }
    }
}
