namespace NDPBase.POO
{
    public class Estudante : Pessoa
    {
        public Estudante(string turma,string nome, string documento, DateTime dataNascimento) : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 3, 6, 8, 5 };
        }

        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar();
            var media = Notas.Average();

            Console.WriteLine($"Sou estudante da turma: {Turma}, minha média é {media}");
        }
    }
}
