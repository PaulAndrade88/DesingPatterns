using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Client
    /// Creates a new object by asking a prototype to clone itself.
    /// </summary>
    class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> _colors =
            new Dictionary<string, ColorPrototype>();

        //Indexer
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
