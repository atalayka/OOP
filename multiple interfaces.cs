using System;

// Interface 1
interface IShape
{
    void Draw();
}

// Interface 2
interface IColor
{
    void FillColor();
}

// Concrete class implementing both interfaces
class Circle : IShape, IColor
{
    public void Draw()
    {
        Console.WriteLine("Circle is drawn.");
    }

    public void FillColor()
    {
        Console.WriteLine("Circle is filled with color.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Circle
        Circle circle = new Circle();

        // Call methods defined in interfaces
        circle.Draw();        // Output: Circle is drawn.
        circle.FillColor();   // Output: Circle is filled with color.
    }
}
