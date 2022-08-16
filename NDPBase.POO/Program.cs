using NDPBase.POO;

var professor = new Professor(5000m, "Professor","3453436", new DateTime(1980, 1, 1));

var estudante = new Estudante("1B", "Estudante","34536", new DateTime(2000, 1, 1));

var pessoas = new List<Pessoa> { professor, estudante };

foreach (var pessoa in pessoas)
{
    pessoa.SeApresentar();
}
