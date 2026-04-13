namespace ProjetoAula13_04
{
    abstract class Pessoa
    {
        public int idade { get; set; }
        public string nome { get; set; }

        public Pessoa (int idade, string nome)
        {
            this.idade = idade;
            this.nome = nome;
        }

        abstract public void ExibirTipo();

        abstract public void Apresentar();

    }

    class Aluno : Pessoa
    {

        public int matricula;
        public Aluno(int idade, string nome , int matricula) : base(idade, nome) {

            this.matricula = matricula;
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("Eu sou um Aluno");
        }

        public override void Apresentar()
        {
            Console.WriteLine("\nMeu nome eh : " + nome + " minha idade eh : " + idade + " matricula : " + matricula);
        }
    }

    class Professor : Pessoa
    {

        public string disciplina;
        public Professor( int idade , string nome , string disciplina ) : base(idade,nome) { 
        
            this.disciplina = disciplina;
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("Eu sou um Professor");
        }
        public override void Apresentar()
        {
            Console.WriteLine("\nMeu nome eh : " + nome + " minha idade eh : " + idade + " disciplina : " + disciplina);
        }
    }

    class Funcionario : Pessoa
    {

        public string cargo;
        public Funcionario(int idade, string nome, string cargo) : base(idade, nome)
        {

            this.cargo = cargo;
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("Eu sou um Funcionario");
        }
        public override void Apresentar()
        {
            Console.WriteLine("\nMeu nome eh : " + nome + " minha idade eh : " + idade + " Cargo : " + cargo);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> p = new List<Pessoa>();

            p.Add(new Aluno(20,"leonardo",2244));
            p.Add(new Professor(38, "ricardo", "Sistemas Embarcados"));
            p.Add(new Professor(32, "Herysson", "Projeto de Software"));
            p.Add(new Funcionario(52, "fabio", "Porteiro e Segurança"));

            foreach (Pessoa a in p)
            {
                    a.Apresentar();
                    a.ExibirTipo();
            }
        }
    }
}
