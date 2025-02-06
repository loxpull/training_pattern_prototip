using System;

public abstract class Shape
{
    private int x;
    private int y;
    private string color;

    public Shape() { }

    public Shape(Shape source)
    {
        this.x = source.x;
        this.y = source.y;
        this.color = source.color;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public abstract Shape Clone();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"X: {X}, Y: {Y}, Color: {Color}");
    }
}

public class Rectangle : Shape
{
    private int width;
    private int height;

    public Rectangle() { }

    public Rectangle(Rectangle source) : base(source)
    {
        this.width = source.width;
        this.height = source.height;
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }

    public override void PrintInfo()
    {
        Console.Write("Rectangle - ");
        base.PrintInfo();
        Console.WriteLine($"Width: {Width}, Height: {Height}");
    }
}

public class Circle : Shape
{
    private int radius;

    public Circle() { }

    public Circle(Circle source) : base(source)
    {
        this.radius = source.radius;
    }

    public int Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }

    public override void PrintInfo()
    {
        Console.Write("Circle - ");
        base.PrintInfo();
        Console.WriteLine($"Radius: {Radius}");
    }
}

public class Cube : Shape
{
    private int side;

    public Cube() { }

    public Cube(Cube source) : base(source)
    {
        this.side = source.side;
    }

    public int Side
    {
        get { return side; }
        set { side = value; }
    }

    public override Shape Clone()
    {
        return new Cube(this);
    }

    public override void PrintInfo()
    {
        Console.Write("Cube - ");
        base.PrintInfo();
        Console.WriteLine($"Side: {Side}");
    }
}

public class Sphere : Shape
{
    private int radius;

    public Sphere() { }

    public Sphere(Sphere source) : base(source)
    {
        this.radius = source.radius;
    }

    public int Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override Shape Clone()
    {
        return new Sphere(this);
    }

    public override void PrintInfo()
    {
        Console.Write("Sphere - ");
        base.PrintInfo();
        Console.WriteLine($"Radius: {Radius}");
    }
}

public class Application
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle
        {
            X = 10,
            Y = 20,
            Color = "Red",
            Width = 100,
            Height = 50
        };

        Circle circle = new Circle
        {
            X = 30,
            Y = 40,
            Color = "Blue",
            Radius = 25
        };

        Cube cube = new Cube
        {
            X = 50,
            Y = 60,
            Color = "Green",
            Side = 30
        };

        Sphere sphere = new Sphere
        {
            X = 70,
            Y = 80,
            Color = "Yellow",
            Radius = 15
        };

        Rectangle rectangleClone = (Rectangle)rectangle.Clone();
        rectangleClone.X = 15;

        Circle circleClone = (Circle)circle.Clone();
        circleClone.Radius = 30;

        Cube cubeClone = (Cube)cube.Clone();
        cubeClone.Side = 35;

        Sphere sphereClone = (Sphere)sphere.Clone();
        sphereClone.Radius = 20;

        rectangle.PrintInfo();
        rectangleClone.PrintInfo();

        circle.PrintInfo();
        circleClone.PrintInfo();

        cube.PrintInfo();
        cubeClone.PrintInfo();

        sphere.PrintInfo();
        sphereClone.PrintInfo();

        Console.ReadKey();
    }
}