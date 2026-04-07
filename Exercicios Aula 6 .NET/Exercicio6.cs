class Veiculo {
    public virtual double CalcularPedagio() => 0;
}
class Carro : Veiculo {
    public override double CalcularPedagio() => 10;
}
class Caminhao : Veiculo {
    public int eixos;
    public override double CalcularPedagio() => eixos * 10;
}
class Program {
    static void Main() {
        List<Veiculo> lista = new List<Veiculo>();
        string op;
        do {
            op = Console.ReadLine();
            if(op == "1") lista.Add(new Carro());
        } while(op != "0");
        
        double total = 0;
        foreach(var v in lista) total += v.CalcularPedagio();
        Console.WriteLine(total);
    }
}
