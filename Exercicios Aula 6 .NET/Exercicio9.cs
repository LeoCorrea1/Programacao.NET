abstract class Produto {
    public double preco;
    public abstract double PrecoFinal();
}
class ProdNacional : Produto {
    public override double PrecoFinal() => preco;
}
class ProdImportado : Produto {
    public override double PrecoFinal() => (preco * 1.20) + 10;
}
class Carrinho {
    static void Main() {
        var itens = new List<Produto> { new ProdNacional{preco=10}, new ProdImportado{preco=50} };
        double soma = 0;
        foreach(var i in itens) soma += i.PrecoFinal();
        Console.WriteLine(soma);
    }
}
