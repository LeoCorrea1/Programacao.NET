class Personagem {
    public string nome;
    public virtual void Atacar() {}
}
class Guerreiro : Personagem {
    public override void Atacar() => Console.WriteLine(nome + " ataca com Espada");
}
class Mago : Personagem {
    public override void Atacar() => Console.WriteLine(nome + " ataca com Magia");
}
class Program {
    static void Main() {
        var p = new List<Personagem> { new Mago{nome="Galdalf"}, new Guerreiro{nome="Conan"} };
        for(int i=0; i<3; i++) {
            foreach(var person in p) person.Atacar();
        }
    }
}
