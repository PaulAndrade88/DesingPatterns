using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// CustomerDataObject
    /// It is the ConcreteImplementor
    /// Implements the Implementor interface and defines its concrete implmentation.
    /// </summary>
    class CustomersData : DataObject
    {
        private List<string> _customers = new List<string>();
        private int _current = 0;

        public CustomersData()
        {            
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public override void NextRecord() =>
            _ = _current <= _customers.Count - 1 ? _current++ : _current;

        public override void PriorRecord() => 
            _ = _current > 0 ? _current-- : _current;

        public override void AddRecord(string customer) =>        
            _customers.Add(customer);
        

        public override void DeleteRecord(string customer) =>
            _customers.Remove(customer);
        
        public override void ShowRecord() =>
            Console.WriteLine(_customers[_current]);

        public override void ShowAllRecords() => 
            _customers.ForEach(c => Console.WriteLine(" " + c));

    }
}
