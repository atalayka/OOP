using System;

// Base class
class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived class
class Dog : Animal
{
    // Sealed override method
    public sealed override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof! Woof!");
    }
}

// Further derived class (attempting to override the sealed method)
class Puppy : Dog
{
    // Attempting to override the sealed method - this will result in a compilation error
    // public override void MakeSound() { }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Dog
        Dog dog = new Dog();

        // Call the overridden method
        dog.MakeSound();  // Output: Dog barks: Woof! Woof!
    }
}
