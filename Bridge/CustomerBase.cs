using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// BusinessObject
    /// Is the Abstraction
    /// Defines the abstraction's interface
    /// Mantains a reference to an object of type implementor.
    /// </summary>
    class CustomerBase
    {
        private DataObject _dataObject;
        protected string group;

        public CustomerBase() { }

        public CustomerBase(string group) => this.group = group;

        public DataObject Data
        {
            set { _dataObject = value; }
            get { return _dataObject; }
        }

        public virtual void Next() => _dataObject.NextRecord();

        public virtual void Prior() => _dataObject.PriorRecord();

        public virtual void Add(string customer) => _dataObject.AddRecord(customer);

        public virtual void Delete(string customer) => _dataObject.DeleteRecord(customer);

        public virtual void Show() => _dataObject.ShowRecord();

        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + group);
            _dataObject.ShowAllRecords();
        }

    }
}
