using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// CustomerBusinessObject
    /// Is the RefinedAbstraction
    /// Extends the interface defined by Abstraction.
    /// </summary>
    class Customers : CustomerBase
    {
        public Customers(string group)
            : base(group) { }

        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            base.ShowAll();
            Console.WriteLine("-----------------------");
        }
    }
}
