using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adapter
    /// Adapts the interface Adaptee to the Target interface.
    /// </summary>
    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        public RichCompound(string name)
            : base(name) { }

        public override void Display()
        {
            _bank = new ChemicalDatabank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();
            Print(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint); 
        }

        private static void Print(string format, object arg) =>
            Console.WriteLine(format, arg);
        

    }
}
