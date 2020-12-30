using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Product
    /// Represents the complex object under construction.
    /// Includes classes that define the constituent parts, including interfaces for assembling the parts into the final result.
    /// </summary>
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts =
            new Dictionary<string, string>();

        public Vehicle(string vehicleType) => _vehicleType = vehicleType;

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
