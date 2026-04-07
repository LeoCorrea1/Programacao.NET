abstract class Mensagem {
    public string msg;
    public abstract void Enviar();
}
class Email : Mensagem {
    public override void Enviar() => Console.WriteLine("Enviando Email: " + msg);
}
class SMS : Mensagem {
    public override void Enviar() => Console.WriteLine("Enviando SMS: " + msg);
}
class Program {
    static void Main() {
        Email e = new Email { msg = "Ola" };
        e.Enviar();
    }
}
