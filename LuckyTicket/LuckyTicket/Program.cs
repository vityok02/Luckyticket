Console.WriteLine("Привет, введите номер билета");
string a = Console.ReadLine();
Console.WriteLine($"Your ticket`s number is: {a}");
if (a.Length < 4)
{
    Console.WriteLine("Твой билет имеет недостаточное количество символов");
}
else if (a.Length > 8)
{
    Console.WriteLine("Твой билет имеет много символов");
}