#region Now

var now = DateTime.Now;

#endregion

#region Today

var today = DateTime.Today;

#endregion

#region AddDays

var threeDaysAgo = today.AddDays(-3);

#endregion

#region AddMonths

var threeMonthsLater = today.AddMonths(6);

#endregion

#region AddYears

var threeYearsLater = today.AddYears(2);

#endregion

#region ToShortDate

var shortDate = now.ToShortDateString();

#endregion

#region ToLongDate

var longDate = now.ToLongDateString();

#endregion

#region ToShortTime

var shortTime = now.ToShortTimeString();

#endregion

#region ToLongTime

var longTime = now.ToLongTimeString();

#endregion

#region TimeSplit

var date = now.Date;
var year = now.Year;
var month = now.Month;
var day = now.Day;
var hour = now.Hour;
var minute = now.Minute;
var second = now.Second;
var microsecond = now.Millisecond;

var dayOfWeek = now.DayOfWeek;
#endregion

#region dayOfWeek

if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Monday )
    Console.WriteLine("É fim de semana!");

#endregion

#region DateTime Formatacao
Console.WriteLine("Formatos: ");
var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "Y" };

foreach (var format in formats)
{
    //Console.WriteLine("Data no Formatado {0}: {1}", format, now.ToString(format));
    Console.WriteLine($"Data no Formatado {format}: {now.ToString(format)}" );
}
Console.WriteLine("Diferentes maneiras de formatar manualmente: ");
Console.WriteLine($"Data no Formato d: {now:d}");
Console.WriteLine($"Data no Formato MM-dd-yyyy: {now:MM-dd-yyyy}");
var dateFormat = now.ToString("MM-dd-yyyy");
var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");

#endregion