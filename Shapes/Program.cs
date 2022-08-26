// See https://aka.ms/new-console-template for more information
abstract class shape
{
    public abstract double area();
    public abstract double perimeter();
}
class Circle : shape
{
    readonly double pi = 3.14;
    public double radius { get; set; }
    public override double area()
    {
        return pi * radius * radius;

    }
    public override double perimeter()
    {
        return 2 * pi * radius;

    }
}
class Square: shape
{
    public double width { get; set; }
    public override double area()
    {
        return width * width;
    }
    public override double perimeter()
    {
        return 4 * width;
    }
}
internal class Shapes
{
    static void Main(string[] args)
    {
        string tempo, ans;
        Circle c = new Circle();
        Square sq = new Square();
        do
        {
            Console.Write("Enter the radius of the circle: ");
            tempo = Console.ReadLine();
            c.radius = Convert.ToDouble(tempo);
            Console.WriteLine("Area of the circle is: " + c.area());
            Console.WriteLine("Enter the width of the square: ");
            tempo = Console.ReadLine();
            sq.width = Convert.ToDouble(tempo);
            Console.Write("Area of the square is: " + sq.area());
            Console.WriteLine("Perimeter of the square is: " + sq.perimeter());
            Console.WriteLine("Would you like to proceed? yes/no: ");
            ans = Console.ReadLine();
        }
        while (ans == "yes");
            Console.ReadKey();
        
    }
}
