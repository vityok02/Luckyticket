do
{
    Console.WriteLine("Привет, введите номер билета");
    string a = Console.ReadLine();
    Console.WriteLine($"Номер твоего билета: {a}");

    if (a.Length < 4)
    {
        Console.WriteLine("Твой билет имеет недостаточное количество символов");
    }
    else if (a.Length > 8)
    {
        Console.WriteLine("Твой билет имеет много символов");
    }
    else
    {
        int n = a.Length % 2;
        if (n != 0)
        {
            a = 0 + a;
        }
        string f = a.Substring(0, a.Length / 2); //firstHalh
        string s = a.Substring(a.Length / 2);    //secondHalf
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < f.Length; i++)
        {
            if (char.IsDigit(f[i]))
            {
                sum1 += Convert.ToInt32(f[i].ToString());
            }
            if (char.IsDigit(s[i]))
            {
                sum2 += Convert.ToInt32(s[i].ToString());
            }
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("=====Поздравляем, счастливый билет!=====");
        }
        else
        {
            Console.WriteLine("=====Повезёт в следующий раз=====");
        }
    }
    Console.WriteLine("нажмите Enter, чтобы продолжить");
    Console.WriteLine("нажмите Esc, чтобы выйти");
} while (Console.ReadKey().Key != ConsoleKey.Escape);