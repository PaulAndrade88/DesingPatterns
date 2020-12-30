using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// ConcreteBuilder
    /// Constructs and assembles parts of the product by implementing the Builder interface.
    /// Defines and keeps track of the representation it creates.
    /// Provides an interface for retrieving the product.
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder() => vehicle = new Vehicle("Car");

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}
