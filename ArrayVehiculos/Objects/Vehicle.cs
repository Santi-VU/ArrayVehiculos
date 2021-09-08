using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayVehiculos
{
    class Vehicle
    {
        public string type { get; protected set; }
        public string mark { get; protected set; }
        public string model { get; protected set; }
        public int wheels { get; protected set; }
    }
}
