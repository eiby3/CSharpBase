namespace NDPBase.POO
{
    public class Professor : Pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento) : base(nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "1B", "2B", "3B" };
        }

        public List<string> Turmas { get; private set; }
        public decimal Salario { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar();
            var turmas = string.Join(",", Turmas);

            Console.WriteLine($"Meu salario é {Salario}, ensino para as turmas: {turmas}");
        }
    }
}
