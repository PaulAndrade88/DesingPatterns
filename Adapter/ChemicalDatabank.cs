using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adaptee
    /// Defines an existing interface that needs adapting.
    /// </summary>
    class ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            if(point == "M")
            {
                switch(compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            else
            {
                return (compound.ToLower()) switch
                {
                    "water" => 100.0f,
                    "benzene" => 80.1f,
                    "ethanol" => 78.3f,
                    _ => 0f,
                };
            }
        }

        public string GetMolecularStructure(string compound)
        {
            return (compound.ToLower()) switch
            {
                "water" => "H2O",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => string.Empty
            };
        }

        public double GetMolecularWeight(string compound)
        {
            return (compound.ToLower()) switch
            {
                "water" => 18.015,
                "benzene" => 78.1134,
                "ethanol" => 46.0688,
                _ => 0d
            };
        }
    }
}
