var paragrafo = "   C# é uma linguagem morderna e versátil. " +
    "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
    "Mobile, entre outros.";

#region Length
var tamanho = paragrafo.Length;

#endregion

#region Empty
var vazio = string.Empty;

#endregion

#region ToLower, ToUpper
var paragrafoMinuscula = paragrafo.ToLower();
var paragrafoMaiusculo = paragrafo.ToUpper();
#endregion

#region Split
var frases = paragrafo.Split('.');

#endregion

#region Trim, TrimEnd, TrimStart

var paragrafoTrim = paragrafo.Trim(); //retira os espacos em branco
var paragrafoTrimEnd = paragrafo.TrimEnd();
var paragrafoTrimStart = paragrafo.TrimStart();

#endregion

#region IsNullOrWhiteSpace
var isNullOrWhiteSpace = string.IsNullOrEmpty(paragrafo);

#endregion

#region Replace
var paragrafoCsharp = paragrafo.Replace("C#", "CSharp");

#endregion

var outroParagrafo = "C# é uma linguagem morderna e versátil. " +
    "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
    "Mobile, entre outros.";

#region IndexOf
var indexOf = outroParagrafo.IndexOf("C#");


#endregion

#region LastIndexOf
var lastIndexOf = outroParagrafo.LastIndexOf("C#");


#endregion

#region StartsWith

var startsWith = outroParagrafo.StartsWith("C#");

#endregion

#region Substring
var indexOfMobile = outroParagrafo.IndexOf("Mobile");
var substringMobile = outroParagrafo.Substring(indexOfMobile, "Mobile".Length);


#endregion

#region Contains
var containsJogos = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
var containsJogosExact = outroParagrafo.Contains("Jogos");
var containsRuim = outroParagrafo.Contains("ruim");
#endregion

Console.ReadKey();