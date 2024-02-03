// Abstract class representing generic shapes
public abstract class Shape
{
    public string Name { get; set; } // Common property

    // Abstract method for calculating area (implementation required in derived classes)
    public abstract double CalculateArea();
}

// Derived class representing a circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class representing a rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Usage example
static void Main(string[] args)
{
    // Create circle and rectangle objects
    Circle circle = new Circle { Radius = 5 };
    Rectangle rectangle = new Rectangle { Width = 4, Height = 3 };

    // Calculate and display areas using polymorphism
    Console.WriteLine($"Circle area: {circle.CalculateArea():F2}");
    Console.WriteLine($"Rectangle area: {rectangle.CalculateArea():F2}");
}
