using System;

namespace Bridge
{
    class Program
    {
        /// <summary>
        /// BRIDGE
        ///  Decouple an abstraction from its implementation so that the two can vary independently.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Customers customers = new Customers("Chicago");
            //customers.Data = new CustomersData();
            Customers customers = new Customers("Chicago")
            {
                Data = new CustomersData()
            };

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            Console.ReadKey();
        }
    }
}
