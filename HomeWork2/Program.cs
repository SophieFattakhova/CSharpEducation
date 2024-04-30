/* Программа №2
Необходимо создать консольное приложение, в котором пользователь может ввести свое имя, фамилию и дату рождения. 
Эти данные пользователь должен вводить по очереди. Дата рождения должна быть записана только числами (например, 22.11.1997). 
В ответ на введённые данные пользователь получает строку с их представлением. Для представления есть несколько условий:
-если количество символов в фамилии превышает 10, то на экран выводится только первая буква фамилии с точкой на конце; 
иначе фамилия выводится полностью без точки на конце.
- месяц, переданный в виде числа, на экран выводится в виде строки (например, 22.11.1997 - 22 ноября 1997) */


Console.WriteLine("Введите имя:");
string? name = Console.ReadLine();

Console.WriteLine("Введите фамилию:");
string? lastName = Console.ReadLine();

Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ.");
string? birthday = Console.ReadLine();


if (lastName.Length >= 10)
{ lastName =  $"{lastName.Substring(0,1)}."; };

var birthdayArray = birthday.Split('.');
var day = birthdayArray[0];
var month = birthdayArray[1];
var year = birthdayArray[2];

switch (month)
{
    case "01":
        month = "январь";
        break;

    case "02":
        month = "февраль";
        break;

    case "11":
        month = "ноябрь";
        break;

    case "12":
        month = "декабрь";
        break;
}

Console.WriteLine($"{name} {lastName}, {day} {month} {year}");

/* Циклы почитать и написать конспект про предыдущие уроки + сегодня.*/

