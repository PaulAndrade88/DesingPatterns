using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Shop
    {
        /// <summary>
        /// Director
        /// Constructs an object using the Builder interface.
        /// </summary>
        /// <param name="vehicleBuilder"></param>
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
