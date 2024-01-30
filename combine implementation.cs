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
    // Override method with base method call
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof! Woof!");
        
        // Call base implementation
        base.MakeSound();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Dog
        Dog dog = new Dog();

        // Call the overridden method
        dog.MakeSound();  
        // Output: 
        // Dog barks: Woof! Woof!
        // Animal makes a sound.
    }
}
