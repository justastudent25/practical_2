using System.Runtime.Intrinsics.X86;

Console.WriteLine("Выберите номер программы которую хотите запустить: " +
 "\r\n1 - Игра \"Угадай число\"\r\n" +
    "2 - Таблица умножения\r\n" +
    "3 - Вывод делителей числа\r\n" +
    "4 - выход");
bool something = true;

static void Umnojenie()
{
    for (int x = 1; x <= 10; x++)
    {
        for (int y = 1; y <= 10; y++)
        {
            Console.Write((x * y) + "\t");
        }
        Console.WriteLine();
    }
}

static void Igra()
{
    bool something1 = true;
    Random rand = new Random();
    int value = rand.Next(0, 100);
    do
    {
        Console.WriteLine("Введите число: ");
        int chislo = Convert.ToInt32(Console.ReadLine());
        if (chislo == value)
        {
            Console.WriteLine("Число угадано.");
            something1 = false;
        }
        else if (chislo > value)
        {
            Console.WriteLine("Введите число меньше.");
        }
        else
        {
            Console.WriteLine("Введите число больше. ");
        }
    } while (something1 == true);
}

static void Delenie()
{
    Console.WriteLine("Введите число: ");
    int cifra = Convert.ToInt32(Console.ReadLine());
    string c = " ";
    for (int i = 1; i <= cifra; i++)
    {
        if (cifra % i == 0)
        {
            c += i + " ";
        }
    }
    Console.WriteLine(c);
}

do
{
    Console.WriteLine("Введите номер команды:");
    int otvet = Convert.ToInt32(Console.ReadLine());
    if (otvet == 1)
    {
        Igra();
    }
    else if (otvet == 2)
    {
        Umnojenie();
    }
    else if (otvet == 3)
    {
        Delenie();
    }
    else if (otvet == 4)
    {
        something = false;
    }
} while (something == true);
