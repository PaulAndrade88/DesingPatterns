using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// Composite
    /// Defines behavior for components having children.
    /// Stores child components.
    /// Implements child-related operations in the Component interface.
    /// </summary>
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements
            = new List<DrawingElement>();

        public CompositeElement(string name)
            : base(name) { }

        public override void Add(DrawingElement d) =>
            elements.Add(d);
                
        public override void Remove(DrawingElement d) =>
            elements.Remove(d);

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
                "+ " + _name);

            elements.ForEach(e => e.Display(indent + 2));
        }
    }
}
