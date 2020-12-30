using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Prototype
    /// Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
    /// Declares an interface for cloning itself.
    /// </summary>
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
