using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// DataObject
    /// Is the Implementor
    /// Defines the interface for implementation classes
    /// This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different.
    /// Typically the implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
    /// </summary>
    abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}
