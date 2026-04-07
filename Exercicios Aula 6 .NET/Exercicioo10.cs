abstract class Funcionario {
    public double salBase;
    public abstract double Calcular();
}
class Vendedor : Funcionario {
    public double vendas;
    public override double Calcular() => salBase + (vendas * 0.1);
}
class Gerente : Funcionario {
    public double bonus;
    public override double Calcular() => salBase + bonus;
}
class Program {
    static void Main() {
        var list = new List<Funcionario> { new Gerente{salBase=6000, bonus=500} };
        foreach(var f in list) {
            double total = f.Calcular();
            if(total > 5000) Console.WriteLine("Alerta de Orçamento");
        }
    }
}
