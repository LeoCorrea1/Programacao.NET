abstract class Conta {
    protected double saldo;
    public Conta(double s) => saldo = s;
    public abstract void Sacar(double v);
}
class ContaCorrente : Conta {
    public ContaCorrente(double s) : base(s) {}
    public override void Sacar(double v) {
        if(saldo >= v) saldo -= v;
    }
}
class ContaPoupanca : Conta {
    public ContaPoupanca(double s) : base(s) {}
    public override void Sacar(double v) {
        if(saldo >= v + 0.50) saldo -= (v + 0.50);
    }
}
