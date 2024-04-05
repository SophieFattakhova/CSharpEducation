/* Программа №1
Необходимо создать консольное приложение, в котором пользователь может ввести свое имя, фамилию и дату рождения.
Эти данные пользователь должен вводить по очереди.
В ответ на введённые данные пользователь получает строку с их представлением.
 */

Console.WriteLine("Введите имя: ");
string? name = Console.ReadLine();

Console.Write("Введите фамилию: ");
string? lastName = Console.ReadLine();

Console.Write("Введите дату рождения: ");
string? birthdate = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Данные пользователя: " + $"\n{name}; {lastName}; {birthdate};"); //интерполяция и конкатениция строк.

Console.WriteLine();