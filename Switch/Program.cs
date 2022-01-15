using System;



namespace Switch
{

    enum Fruit
    {
        Avocado,
        Pear,
        Apple,
        Banana,
        Mango,
        Orange
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = Fruit.Mango;
            Switch9();
        }
        static void Switch1()
        {
            int n = 2;
            string str = "";
            switch (n)
            {
                case 1:
                    str = "Понедельник";
                    break;
                case 2:
                    str = "Вторник";
                    break;
                case 3:
                    str = "Среда";
                    break;
                case 4:
                    str = "Четверг";
                    break;
                case 5:
                    str = "Пятница";
                    break;
                case 6:
                    str = "Суббота";
                    break;
                case 7:
                    str = "Воскресенье";
                    break;
            }
            Console.WriteLine(str);
        }

        static void Switch2()
        {
            int K = int.Parse(Console.ReadLine());
            switch (K)
            {
                case 1:
                    Console.WriteLine("Bad");
                    break;
                case 2:
                    Console.WriteLine("Not so bad");
                    break;
                case 3:
                    Console.WriteLine("So-so");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Very good");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
        static void Switch3()
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


        }
        static void Switch20()
        {
            int D = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            switch (M)
            {
                case 1:
                    if (D >= 20) Console.WriteLine("Vodolei");
                    else Console.WriteLine("Kozerog");
                    break;
                case 2:
                    if (D >= 19) Console.WriteLine("Ribi");
                    else Console.WriteLine("Vodolei");
                    break;
                case 3:
                    if (D >= 21) Console.WriteLine("Oven");
                    else Console.WriteLine("Ribi");
                    break;
                case 4:
                    if (D >= 20) Console.WriteLine("Telech");
                    else Console.WriteLine("Oven");
                    break;
                case 5:
                    if (D >= 21) Console.WriteLine("Bliznechi");
                    else Console.WriteLine("Telech");
                    break;
                case 6:
                    if (D >= 22) Console.WriteLine("Rak");
                    else Console.WriteLine("Bliznechi");
                    break;
                case 7:
                    if (D >= 23) Console.WriteLine("Lev");
                    else Console.WriteLine("Rak");
                    break;
                case 8:
                    if (D >= 23) Console.WriteLine("Deva");
                    else Console.WriteLine("Lev");
                    break;
                case 9:
                    if (D >= 23) Console.WriteLine("Vesi");
                    else Console.WriteLine("Deva");
                    break;
                case 10:
                    if (D >= 23) Console.WriteLine("Skorpion");
                    else Console.WriteLine("Vesi");
                    break;
                case 11:
                    if (D >= 23) Console.WriteLine("Strelech");
                    else Console.WriteLine("Skorpion");
                    break;
                case 12:
                    if (D >= 22) Console.WriteLine("Kozerog");
                    else Console.WriteLine("Strelech");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void Switch19()
        {
            int year = int.Parse(Console.ReadLine());
            Console.Write("год ");
            switch (year % 10)
            {
                case 0:
                case 1:
                    Console.Write("бел");
                    break;
                case 2:
                case 3:
                    Console.Write("черн");
                    break;
                case 4:
                case 5:
                    Console.Write("зелён");
                    break;
                case 6:
                case 7:
                    Console.Write("красн");
                    break;
                case 8:
                case 9:
                    Console.Write("жёлт");
                    break;
            }
            switch ((year + 1) % 5)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9:
                case 10:
                case 11:
                    Console.Write("ой ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("ого ");
                    break;
            }
            switch ((year + 8) % 12)
            {
                case 0:
                    Console.Write("крысы");
                    break;
                case 1:
                    Console.Write("коровы");
                    break;
                case 2:
                    Console.Write("тигра");
                    break;
                case 3:
                    Console.Write("зайца");
                    break;
                case 4:
                    Console.Write("дракона");
                    break;
                case 5:
                    Console.Write("змеи");
                    break;
                case 6:
                    Console.Write("лошади");
                    break;
                case 7:
                    Console.Write("овцы");
                    break;
                case 8:
                    Console.Write("обезьяны");
                    break;
                case 9:
                    Console.Write("курицы");
                    break;
                case 10:
                    Console.Write("собаки");
                    break;
                case 11:
                    Console.Write("свиньи");
                    break;
            }
        }
        static void Switch18()
        {
            //Почему тааааак многа писать 😞
            int num = int.Parse(Console.ReadLine());
            switch (num / 100)
            {
                case 1:
                    Console.Write("сто ");
                    break;
                case 2:
                    Console.Write("двести ");
                    break;
                case 3:
                    Console.Write("триста ");
                    break;
                case 4:
                    Console.Write("четыреста ");
                    break;
                case 5:
                    Console.Write("пятьсот ");
                    break;
                case 6:
                    Console.Write("шестьсот ");
                    break;
                case 7:
                    Console.Write("семьсот ");
                    break;
                case 8:
                    Console.Write("восемьсот ");
                    break;
                case 9:
                    Console.Write("девятьсот ");
                    break;
            }
            //тут ваще екшн был, я столько думал
            if ((num % 100) / 10 == 1)
            {
                switch (num % 100)
                {
                    case 10:
                        Console.Write("десять ");
                        break;
                    case 11:
                        Console.Write("одинадцать ");
                        break;
                    case 12:
                        Console.Write("двенадцать ");
                        break;
                    case 13:
                        Console.Write("тринадцать ");
                        break;
                    case 14:
                        Console.Write("четырнадцать ");
                        break;
                    case 15:
                        Console.Write("пятьнадцать ");
                        break;
                    case 16:
                        Console.Write("шестьнадцать ");
                        break;
                    case 17:
                        Console.Write("семьнадцать ");
                        break;
                    case 18:
                        Console.Write("восемьнадцать ");
                        break;
                    case 19:
                        Console.Write("девятьнадцать ");
                        break;
                }
            }
            else
            {
                switch (num / 10 % 10)
                {
                    case 2:
                        Console.Write("двадцать ");
                        break;
                    case 3:
                        Console.Write("тридцать ");
                        break;
                    case 4:
                        Console.Write("сорок ");
                        break;
                    case 5:
                        Console.Write("пятьдесят ");
                        break;
                    case 6:
                        Console.Write("шестьдесят ");
                        break;
                    case 7:
                        Console.Write("семьдесят ");
                        break;
                    case 8:
                        Console.Write("восемьдесят ");
                        break;
                    case 9:
                        Console.Write("девяносто ");
                        break;
                }
            }
            switch (num % 10)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("один");
                    break;
                case 2:
                    Console.Write("два");
                    break;
                case 3:
                    Console.Write("три");
                    break;
                case 4:
                    Console.Write("четыре");
                    break;
                case 5:
                    Console.Write("пять");
                    break;
                case 6:
                    Console.Write("шесть");
                    break;
                case 7:
                    Console.Write("семь");
                    break;
                case 8:
                    Console.Write("восемь");
                    break;
                case 9:
                    Console.Write("девять");
                    break;

            }
        }
        static void Switch17()
        {
            int num = int.Parse(Console.ReadLine());
            if (num / 10 == 1)
            {
                switch (num)
                {
                    case 10:
                        Console.Write("десять ");
                        break;
                    case 11:
                        Console.Write("одинадцать ");
                        break;
                    case 12:
                        Console.Write("двенадцать ");
                        break;
                    case 13:
                        Console.Write("тринадцать ");
                        break;
                    case 14:
                        Console.Write("четырнадцать ");
                        break;
                    case 15:
                        Console.Write("пятьнадцать ");
                        break;
                    case 16:
                        Console.Write("шестьнадцать ");
                        break;
                    case 17:
                        Console.Write("семьнадцать ");
                        break;
                    case 18:
                        Console.Write("восемьнадцать ");
                        break;
                    case 19:
                        Console.Write("девятьнадцать ");
                        break;
                }
            }
            else
            {
                switch (num / 10)
                {
                    case 2:
                        Console.Write("двадцать ");
                        break;
                    case 3:
                        Console.Write("тридцать ");
                        break;
                    case 4:
                        Console.Write("сорок ");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                switch (num % 10)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("одно ");
                        break;
                    case 2:
                        Console.Write("два ");
                        break;
                    case 3:
                        Console.Write("три ");
                        break;
                    case 4:
                        Console.Write("четыре ");
                        break;
                    case 5:
                        Console.Write("пять ");
                        break;
                    case 6:
                        Console.Write("шесть ");
                        break;
                    case 7:
                        Console.Write("семь ");
                        break;
                    case 8:
                        Console.Write("восемь ");
                        break;
                    case 9:
                        Console.Write("девять ");
                        break;

                }
            }
            switch (num % 10)
            {
                case 1:
                    Console.Write("учебное задание");
                    break;
                case 0:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.Write("учебных заданий");
                    break;
            }


        }
        static void Switch16()
        {
            int yearsOld = int.Parse(Console.ReadLine());
            switch (yearsOld / 10)
            {
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            switch (yearsOld % 10)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("один ");
                    break;
                case 2:
                    Console.Write("два ");
                    break;
                case 3:
                    Console.Write("три ");
                    break;
                case 4:
                    Console.Write("четыре ");
                    break;
                case 5:
                    Console.Write("пять ");
                    break;
                case 6:
                    Console.Write("шесть ");
                    break;
                case 7:
                    Console.Write("семь ");
                    break;
                case 8:
                    Console.Write("восемь ");
                    break;
                case 9:
                    Console.Write("девять ");
                    break;

            }
            if (yearsOld % 10 <= 4 && yearsOld % 10 > 1) Console.Write("года");
            else if (yearsOld % 10 == 1) Console.Write("год");
            else Console.Write("лет");

        }
        static void Switch15()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            switch (N)
            {
                case 6:
                    Console.Write("шестерка ");
                    break;
                case 7:
                    Console.Write("семерка ");
                    break;
                case 8:
                    Console.Write("восьмерка ");
                    break;
                case 9:
                    Console.Write("девятка ");
                    break;
                case 10:
                    Console.Write("десятка ");
                    break;
                case 11:
                    Console.Write("валет ");
                    break;
                case 12:
                    Console.Write("дама ");
                    break;
                case 13:
                    Console.Write("король ");
                    break;
                case 14:
                    Console.Write("туз ");
                    break;

            }
            switch (M)
            {
                case 1:
                    Console.Write("пика");
                    break;
                case 2:
                    Console.Write("треф");
                    break;
                case 3:
                    Console.Write("бубен");
                    break;
                case 4:
                    Console.Write("червей");
                    break;

            }
        }
        static void Switch14()
        {
            Console.WriteLine("1 — сторона a, 2 — радиус R1 вписанной окружности, 3 — радиус R2 описанной окружности, 4 — площадь S");
            int num = int.Parse(Console.ReadLine());
            double a, R1, R2, S;
            switch (num)
            {
                case 1:
                    Console.Write("Введи а: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    R1 = a * Math.Sqrt((0.5));
                    R2 = 2 * R1;
                    S = (a * a) * Math.Sqrt((0.75));
                    Console.Write($"a = {a}, R1 = {R1}, R2 = {R2}, S = {S}.");
                    break;
                case 2:
                    Console.Write("Введи R1: ");
                    R1 = Convert.ToDouble(Console.ReadLine());
                    a = R1 / Math.Sqrt((0.5));
                    R2 = 2 * R1;
                    S = (a * a) * Math.Sqrt((0.75));
                    Console.Write($"a = {a}, R1 = {R1}, R2 = {R2}, S = {S}.");
                    break;
                case 3:
                    Console.Write("Введи R2: ");
                    R2 = Convert.ToDouble(Console.ReadLine());
                    R1 = R2 / 2;
                    a = R1 / Math.Sqrt((0.5));
                    S = (a * a) * Math.Sqrt((0.75));
                    Console.Write($"a = {a}, R1 = {R1}, R2 = {R2}, S = {S}.");
                    break;
                case 4:
                    Console.Write("Введи S: ");
                    S = Convert.ToDouble(Console.ReadLine());
                    a = S / Math.Sqrt((0.75));
                    R1 = a * Math.Sqrt((0.5));
                    R2 = 2 * R1;
                    Console.Write($"a = {a}, R1 = {R1}, R2 = {R2}, S = {S}.");
                    break;
                default:
                    Console.WriteLine("ERRORRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR");
                    break;
            }

        }
        static void Switch13()
        {
            Console.Write("Номер элемента: ");
            int n = int.Parse(Console.ReadLine());
            double x, a, c, h, s;


            Console.Write("Длинна: ");
            x = double.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    a = x;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    Console.WriteLine($"{c} {h} {s}");
                    break;
                case 2:
                    c = x;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    Console.WriteLine($"{a} {h} {s}");
                    break;
                case 3:
                    h = x;
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    s = c * h / 2;
                    Console.WriteLine($"{a} {c} {s}");
                    break;
                case 4:
                    s = x;
                    h = Math.Sqrt(s);
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    Console.WriteLine($"{a} {c} {h}");
                    break;
            }
        }
        static void Switch12()
        {
            const double Pi = 3.14;
            Console.Write("1 — радиус R, 2 — диаметр D = 2·R, 3 — длина L = 2·π·R, 4 — площадь круга S = π·R^2");
            int i = int.Parse(Console.ReadLine());
            double R, D, L, S;
            switch (i)
            {
                case 1:
                    R = double.Parse(Console.ReadLine());
                    D = 2 * R;
                    L = 2 * Pi * R;
                    S = Pi * (R * R);
                    Console.WriteLine($"{D} {L} {S}");
                    break;
                case 2:
                    D = double.Parse(Console.ReadLine());
                    R = D / 2;
                    L = 2 * Pi * R;
                    S = Pi * (R * R);
                    Console.WriteLine($"{R} {L} {S}");
                    break;
                case 3:
                    L = double.Parse(Console.ReadLine());
                    R = L / (2 * Pi);
                    D = 2 * R;
                    S = Pi * (R * R);
                    Console.WriteLine($"{R} {D} {S}");
                    break;
                case 4:
                    S = double.Parse(Console.ReadLine());
                    R = S / Pi;
                    R = Math.Sqrt(R);
                    D = 2 * R;
                    L = 2 * Pi * R;
                    Console.WriteLine($"{R} {D} {L}");
                    break;
            }

        }
        static void Switch11()
        {
            int n1, n2;
            char c;
            c = char.Parse(Console.ReadLine());
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 'С':
                    switch (n1 + n2)
                    {
                        case 0:
                            c = 'C';
                            break;
                        case 3:
                            c = 'В';
                            break;
                        case 1:
                            c = 'З';
                            break;
                        case -2:
                        case 2:
                            c = 'Ю';
                            break;
                    }
                    break;

                case 'В':
                    switch (n1 + n2)
                    {
                        case 0:
                            c = 'B';
                            break;
                        case 3:
                            c = 'Ю';
                            break;
                        case 1:
                            c = 'С';
                            break;
                        case -2:
                        case 2:
                            c = 'З';
                            break;
                    }
                    break;
                case 'Ю':
                    switch (n1 + n2)
                    {
                        case 0:
                            c = 'Ю';
                            break;
                        case 3:
                            c = 'З';
                            break;
                        case 1:
                            c = 'В';
                            break;
                        case -2:
                        case 2:
                            c = 'С';
                            break;
                    }
                    break;
                case 'З':
                    switch (n1 + n2)
                    {
                        case 0:
                            c = 'З';
                            break;
                        case 3:
                            c = 'С';
                            break;
                        case 1:
                            c = 'Ю';
                            break;
                        case -2:
                        case 2:
                            c = 'В';
                            break;
                    }
                    break;
            }
            Console.WriteLine(c);

        }
        static void Switch10()
        {
            char c = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 'C':
                    switch (n1)
                    {
                        case 0:
                            c = 'C';
                            break;
                        case 1:
                            c = 'З';
                            break;
                        case -1:
                            c = 'В';
                            break;
                    }
                    break;
                case 'З':
                    switch (n1)
                    {
                        case 0:
                            c = 'З';
                            break;
                        case 1:
                            c = 'Ю';
                            break;
                        case -1:
                            c = 'С';
                            break;
                    }
                    break;
                case 'В':
                    switch (n1)
                    {
                        case 0:
                            c = 'В';
                            break;
                        case 1:
                            c = 'С';
                            break;
                        case -1:
                            c = 'Ю';
                            break;
                    }
                    break;
                case 'Ю':
                    switch (n1)
                    {
                        case 0:
                            c = 'Ю';
                            break;
                        case 1:
                            c = 'В';
                            break;
                        case -1:
                            c = 'З';
                            break;
                    }
                    break;

            }
            Console.WriteLine(c);
        }
        static void Switch9()
        {
            int d, m;
            d = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d == 31) d = 0;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d == 30) d = 0;
                    break;
                case 2:
                    if (d == 28) d = 0;
                    break;
            }
            if (d == 0)
            {
                if (m == 12) m = 1;
                else m++;
            }
            d++;
            Console.WriteLine($"{d} {m}");

        }
        static void Switch7()
        {
            Console.Write("1 — килограмм, 2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер: ");
            int num = int.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    kg = kg;
                    break;
                case 2:
                    kg = 10000 * kg;
                    break;
                case 3:
                    kg = 1000 * kg;
                    break;
                case 4:
                    kg = kg / 1000;
                    break;
                case 5:
                    kg = kg / 100;
                    break;
            }
            Console.WriteLine(kg);
        }
    }
}
