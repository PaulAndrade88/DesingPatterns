using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class ScooterBuilder : VehicleBuilder
    {
        /// <summary>
        /// ConcreteBuilder
        /// Constructs and assembles parts of the product by implementing the Builder interface.
        /// Defines and keeps track of the representation it creates.
        /// Provides an interface for retrieving the product.
        /// </summary>
        public ScooterBuilder() => vehicle = new Vehicle("Scooter");

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
