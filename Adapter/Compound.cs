using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Target
    /// Defines the domain-specific interface that Client uses.
    /// </summary>
    class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound(string chemical) => _chemical = chemical;

        public virtual void Display() => Console.WriteLine("\nCompound: {0} ------ ", _chemical);
    }
}
