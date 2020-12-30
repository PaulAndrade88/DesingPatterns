using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Builder
    /// Specifies an abstract interface for creating parts of a Product object.
    /// </summary>
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
