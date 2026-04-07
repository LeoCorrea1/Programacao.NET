abstract class Forma {
    public abstract double CalcularArea();
}
class Quadrado : Forma {
    public double lado;
    public override double CalcularArea() => lado * lado;
}
class Retangulo : Forma {
    public double b, h;
    public override double CalcularArea() => b * h;
}
class Program {
    static void Main() {
        Quadrado q = new Quadrado();
        Console.WriteLine("Lado:");
        q.lado = double.Parse(Console.ReadLine());
        
        Retangulo r = new Retangulo();
        r.b = 10; r.h = 5;
        Console.WriteLine(q.CalcularArea());
        Console.WriteLine(r.CalcularArea());
    }
}
