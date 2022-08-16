#region Debugging
//Locals e Automatic
var numerosString = "0 1 2 3 4 5";
var numeros = numerosString.Split(' ');

foreach (var numero in numeros)
{
    var numeroInt = int.Parse(numero);

    var aoQuadrado = Math.Pow(2, numeroInt);

    Console.WriteLine($"{numeroInt}² = {aoQuadrado}");
}

#endregion

#region Exceptions

var seteString = "sete";
string valorNull = null;
var longValue = long.MaxValue.ToString();

try
{
    var formatException = int.Parse(seteString);
    var argumentNullException = int.Parse(valorNull);
    var overflowExcecption = int.Parse(longValue);
}
catch (FormatException ex)
{
    Console.WriteLine($"FormatException: {ex.Message}");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"ArgumentNullException: {ex.Message}");
}
catch (OverflowException ex)
{
    Console.WriteLine($"OverflowException: {ex.Message}");
}
finally
{
    Console.WriteLine($"Esse codigo é executado sempre!");
}

#endregion

Console.ReadKey();
