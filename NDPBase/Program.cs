// See https://aka.ms/new-console-template for more information
#region Tipos De Dados

int numeroInt = 10;

int numeroMaxValue = int.MaxValue;
int numeroMinValue = int.MinValue;

long numeroLong = 2337862873672836;

long numeroLongMaxValue = long.MaxValue;
long numeroLongMinValue = long.MinValue;

decimal numeroDecimal = 19.22m;

double numeroDouble = 34.2;
double NumeroDoubleMaxValue = double.MaxValue;

bool verdadeiro = true;
bool falso = false;

var numero = 10;

string nome = "Abe";

char letra = 'A';

DateTime entradaEmpresa = new DateTime(2021, 09, 01);
TimeSpan tempoDeEmpresa = DateTime.Now - entradaEmpresa;

#endregion

#region Conversao de Tipos

int notaAluno = 10;

//Conversao implicita
double notaAlunoDouble = notaAluno;

//Conversao explicita
int numeroDoubleComoInt = (int)notaAlunoDouble;

//Conversao com Convert
string notaString = "10";

int numeroConvert = Convert.ToInt32(notaString);

//Conversao com Parse
int numeroParse = int.Parse(notaString);

if (int.TryParse(notaString, out int notaParse))
{
    //caso a conversao de certo.
}

#endregion

#region Operadores Aritmeticos

//Unarios ++, --, + e -
int numeroOperador = 4;

//Console.WriteLine(numeroOperador++); //4, após essa linha ficará 5
//Console.WriteLine(++numeroOperador); //5

//Console.WriteLine(numeroOperador--); // 4, após essa linha ficará 3
//Console.WriteLine(--numeroOperador); // 3

//Console.WriteLine(+numeroOperador); // 4
//Console.WriteLine(-numeroOperador); // -4
//Console.WriteLine(-(-numeroOperador)); // 4

//Binarios * / + -

var soma = 4 + 5;
var sub = 4 - 5;
var mult = 4 * 5;
var div = 20 / 3;
var divisaoDouble = (double)20 / 3;

var multiplos = (4 * 5) + 10;
#endregion

#region Operadores de Comparacao

// > >= < <=

var verdadeiroOuFalso = 4 > 5;
verdadeiroOuFalso = 5 > 5;
verdadeiroOuFalso = 5 >= 5;
verdadeiroOuFalso = 5 < 4;
verdadeiroOuFalso = 5 <= 5;
verdadeiroOuFalso = 5 < 6;

#endregion

#region Operadores de Igualdade
// == , !=

var IsIgual = 5 == 5;
IsIgual = 5 == 4;

IsIgual = 5 != 5;
IsIgual = 5 != 4;

#endregion

#region Operadores Logicos
//And && e OR ||

var operadoresLogicos = true || false; // true
operadoresLogicos = false || true; //true
operadoresLogicos = true || true; //true
operadoresLogicos = false || false; //false

operadoresLogicos = true && false; // false
operadoresLogicos = false && true; //false
operadoresLogicos = true && true; //true
operadoresLogicos = false && false; //false
#endregion