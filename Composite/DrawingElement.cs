using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// The 'Component' Treenode
    /// Declares the interface for objects in the composition.
    /// Implements default behavior for the interface common to all classes, as apropiate.
    /// Declares an interface for accesing and managing its child components.
    /// (Optional) Defines an interface for accesing a component's parent in the recursive structure, and implements if that's appropiate. 
    /// </summary>
    abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name) => _name = name;

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}
