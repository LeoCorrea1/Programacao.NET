abstract class ItemBiblioteca {
    public string titulo, autor;
    public abstract void ExibirDestaque();
}
class Livro : ItemBiblioteca {
    public override void ExibirDestaque() => Console.WriteLine(titulo.ToUpper());
}
class Revista : ItemBiblioteca {
    public int edicao;
    public override void ExibirDestaque() => Console.WriteLine(titulo + " " + edicao);
}
