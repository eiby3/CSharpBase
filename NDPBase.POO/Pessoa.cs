namespace NDPBase.POO
{
    public abstract class Pessoa
    {
        protected Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; set; }

        public virtual void SeApresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Documento {Documento}, " +
                $"Data de Nascimento: {DataNascimento}");
        }

    }
}
