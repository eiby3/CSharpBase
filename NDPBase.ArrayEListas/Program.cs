//-----------------------Array----------------------
//Array ou matriz é uma estrutura de dados que permite o armazenamento de dados do mesmo tipo
//Caso queira armazenar elementos de qualquer tipo, object pode ser definido como o tipo
//Permite iteração entre seus valores atráves de estruturas de repetição como for, while e foreach

//----------------------List------------------------
//Estrutura de dados fortemente tipada de objetos
//Oferece uma grande quantidade de métodos auxiliares, como inserção, remoção, busca, entre outros
//São extendidas de maneira incrivel com os métodos LINQ (namespace System.Linq)
//São muito utilizadas no dia a dia de um desenvolvedor .NET

#region Arrays
int[] numbersOutraForma = { 0, 1, 2, 3, 4, 5, 6 };
var numbersComCapacidade = new int[7];
var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };

for (int i = 0; i < numbers.Length; i++)
{
    numbersComCapacidade[i] = numbers[i];
}
var numbersString = "0 1 2 3 4 5 6";
var numbersArray = numbersString.Split(' ');

//for (int i = 0; i < numbersArray.Length; i++)
//{
//    numbersComCapacidade[i] = int.Parse(numbersArray[i]);
//}
var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);

#endregion

#region Listas
var list = new List<int>() { 0, 1, 2, 3, 4};
var listFromArray = new List<int>(numbers);

list.Add(5);
list.AddRange(new List<int> { 6, 7 });
list.AddRange(new int[] { 8, 9 });

var count = list.Count;
var contains14 = list.Contains(14);
var contains2 = list.Contains(2);

Console.WriteLine("----Lista reversa----");
list.Reverse();
list.ForEach(_ => Console.WriteLine(_));

Console.WriteLine("----Lista ordenada----");
list.Sort();
list.ForEach(_ => Console.WriteLine(_));

list.Remove(4);
list.RemoveAll(_ => _ > 5);

list.Clear();
#endregion


//LINQ ou Language-Integrated Query, é uma sintaxe para consultas em .NET, compatível com diferentes fontes de dados
//Amplamente utilizado no dia a dia, extendendo grandemente a capacidade de coleções como List

#region LINQ

var students = new List<Student>
{
    new Student(1, "Abe", "12345678910", 100),
    new Student(2, "Alana", "3453453453", 32),
    new Student(3, "Vitor", "1231346865", 85),
    new Student(4, "Sam", "23467865134", 70),
    new Student(5, "Abe", "235789789", 75),
};

#endregion
#region Any

var any = students.Any();
var any100 = students.Any(_ => _.Grade == 100);

#endregion
#region Single / SingleOrDefault

var single = students.Single(_ => _.Id == 1);
var singleOrDefault = students.SingleOrDefault(_ => _.Document == "12345678910");

#endregion
#region First / FirstOrDefault

var first = students.First(_ => _.FullName == "Abe");
var firstOrDefault = students.FirstOrDefault(_ => _.Grade == 0);

#endregion
#region OrderBy / OrderByDescending

var orderedByGrade = students.OrderBy(_ => _.Grade);
var orderedByGradeDescending = students.OrderByDescending(_ => _.Grade);

#endregion
#region Where

var approvedStudentes = students.Where(_ => _.Grade >= 70);

#endregion
#region Select / SelectMany

var grades = students.Select(_ => _.Grade);
var phoneNumbers = students.SelectMany(_ => _.PhoneNumbers);

#endregion

#region Sum / Min / Max / Count

var sum = students.Sum(_ => _.Grade);
var mim = students.Min(_ => _.Grade);
var max = students.Max(_ => _.Grade);

var countLinq = students.Count;
#endregion


Console.ReadKey();


public class Student
{
    public Student(int id, string fullName, string document, int grade)
    {
        Id = id;
        FullName = fullName;
        Document = document;
        Grade = grade;
        PhoneNumbers = new List<string> { "12314143245", "3526457645", "23455654" };
    }

    public int Id { get; set; }
    public string FullName { get; set; }
    public string Document { get; set; }
    public int Grade { get; set; }

    public List<string> PhoneNumbers { get; set; }
}