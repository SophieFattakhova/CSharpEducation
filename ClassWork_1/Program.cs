
int monday = 1;
int wednesday = 3;
int day = 5;

if (day == monday)
{ Console.WriteLine("Сегодня понедельник!");}
else { Console.WriteLine("Сегодня не понедельник");}

if (day == monday || day == wednesday)
{ Console.WriteLine("Сегодня день мороженого!"); }

//тернарное выражение
var result = day == monday ? "Сегодня понедельник!" : "Cегодня не понедельник!";
Console.WriteLine(result);
