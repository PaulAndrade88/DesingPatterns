using System;

namespace Adapter
{
    /// <summary>
    /// Client
    /// Convert the interface of a class into another interface clients expect.
    /// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {            
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
                        
            Console.ReadKey();
        }
    }
}
