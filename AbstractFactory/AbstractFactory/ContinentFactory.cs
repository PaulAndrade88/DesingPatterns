using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// AbstractFactory
    /// Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// </summary>
    abstract class ContinentFactory//AbstractFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}

/// <summary>
/// AbstractFactory
/// The classes and objects participating in this pattern are:
/// 
/// AbstractFactory  (ContinentFactory)
///     Declares an interface for operations that create abstract products
/// ConcreteFactory(AfricaFactory, AmericaFactory)
///     Implements the operations to create concrete product objects
/// AbstractProduct   (Herbivore, Carnivore)
///     Declares an interface for a type of product object
/// Product(Wildebeest, Lion, Bison, Wolf)
///     Defines a product object to be created by the corresponding concrete factory
///     Implements the AbstractProduct interface
/// Client  (AnimalWorld)
///     Uses interfaces declared by AbstractFactory and AbstractProduct classes
/// </summary>