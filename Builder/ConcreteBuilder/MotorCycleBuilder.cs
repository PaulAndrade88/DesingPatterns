using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MotorCycleBuilder : VehicleBuilder
    {
        /// <summary>
        /// ConcreteBuilder
        /// Constructs and assembles parts of the product by implementing the Builder interface.
        /// Defines and keeps track of the representation it creates.
        /// Provides an interface for retrieving the product.
        /// </summary>
        public MotorCycleBuilder() => vehicle = new Vehicle("MotorCycle");

        public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}
