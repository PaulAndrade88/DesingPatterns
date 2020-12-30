﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// Leaf
    /// Represents leaf objects in the composition. A leaf has no children.
    /// Defines behavior for primitive objects in the composition.
    /// </summary>
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name)
            :base(name) { }

        public override void Add(DrawingElement c) =>
            Console.WriteLine("Cannot add to a PrimitiveElement");

        public override void Remove(DrawingElement c) =>
            Console.WriteLine("Cannot remove from a PrimitiveElement");

        public override void Display(int indent) =>
            Console.WriteLine(new String('-', indent) + " " + _name);
    }
}
