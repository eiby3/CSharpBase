#region Else/if

//var notaDigitada = Console.ReadLine();

//if(int.TryParse(notaDigitada, out int nota))
//{
//    if (nota >= 70 )
//        Console.WriteLine("Aprovado.");
//    else if (nota >= 40)
//        Console.WriteLine("Recuperacao.");
//    else
//        Console.WriteLine("Reprovado.");
//}
//else
//    Console.WriteLine("Nota invalida.");

#endregion

#region Switch case
//switch (notaDigitada)
//{
//    case "0":
//        Console.WriteLine("Digitou 0");
//        break;
//    case "1":
//        Console.WriteLine("Digitou 1");
//        break;
//    case "2":
//        Console.WriteLine("Digitou 1");
//        break;
//    default:
//        Console.WriteLine("Opcao nao encontrada");
//        break;
//}
#endregion

#region For

Console.WriteLine("Digite uma sequência de numeros separados por espacos.");

var numerosTexto = Console.ReadLine();

var numeros = numerosTexto.Split(' ');
Console.WriteLine("--------------FOR---------------");
Console.WriteLine("Numeros: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
#endregion

#region While
Console.WriteLine("--------------WHILE---------------");
var contador = 0;
while (contador < numeros.Length)
{
    Console.WriteLine(numeros[contador]);
    contador++;
}

#endregion

#region Foreach
Console.WriteLine("--------------FOREACH---------------");
foreach (var item in numeros)
{
    Console.WriteLine(item);
}

#endregion