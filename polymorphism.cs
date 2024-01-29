class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        // Call the base class implementation first
        base.MakeSound();//**

        // Add the dog's specific sound
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();  // Output: Generic animal sound
                          //Woof!
    }
}
