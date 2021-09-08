using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayVehiculos
{
    internal class Scooter : Vehicle, IVehicable
    {   
        public bool seat { get; protected set; }
        public double km { get; protected set; }

        public Scooter() {
            this.type = "";
            this.mark = "";
            this.model = "";
            this.wheels = -1;
            this.seat = false;
            this.km = -1;
        }

        public Scooter(string type, string mark, string model, int wheels, bool seat, double km)
        {
            this.type = type;
            this.mark = mark;
            this.model = model;
            this.wheels = wheels;
            this.seat = seat;
            this.km = km;
        }

        public void VehicleType()
        {
            Console.WriteLine("Tipo: " + this.type);
        }

        public void VehicleInfo()
        {
            string auxSeat;
            if (this.seat == false)
            {
                auxSeat = "No";
            }
            else {
                auxSeat = "Sí";
            }
            VehicleType();
            Console.WriteLine("\t" + "Marca: " + this.mark + " " + this.model + "\n" + 
                              "\t" + "Asiento: " + auxSeat + ", Kilometros: " + this.km.ToString());
        }
    }
}
