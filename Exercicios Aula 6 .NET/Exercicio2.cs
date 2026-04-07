class AparelhoSom {
    public int volume = 0;
    public virtual void AumentarVolume() => volume++;
}
class Radio : AparelhoSom {
    public override void AumentarVolume() => volume += 1;
}
class HomeTheater : AparelhoSom {
    public override void AumentarVolume() => volume += 5;
}
class Program {
    static void Main() {
        var aparelhos = new List<AparelhoSom> { new Radio(), new HomeTheater() };
        foreach(var a in aparelhos) {
            a.AumentarVolume();
        }
    }
}
