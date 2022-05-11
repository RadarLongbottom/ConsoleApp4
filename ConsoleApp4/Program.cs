Console.WriteLine("Witaj w aplikacji przelicznika walut!!!");
Console.WriteLine();
Console.WriteLine("Naciśnij dowolny przycisk aby rozpocząć...");
Console.ReadKey(true);
Console.WriteLine();
Console.WriteLine("Wybierz walutę bazową: ");
Console.WriteLine("1 - Złoty");
Console.WriteLine("2 - Dolar Amerykański");
Console.WriteLine("3 - Euro");
Console.WriteLine("4 - Funt Brytyjski");
Console.Write("Twój wybór waluty bazowej: ");
double walB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
switch (walB)
{
    case 1:
        Console.WriteLine("Wybrano walutę: Polski Złoty");
        break;
    case 2:
        Console.WriteLine("Wybrano walutę: Dolar Amerykański");
        break;
    case 3:
        Console.WriteLine("Wybrano walutę: Euro");
        break;
    case 4:
        Console.WriteLine("Wybrano walutę: Funt Brytyjski");
        break;
}
Console.WriteLine();
Console.WriteLine("Wybierz walutę na którą chcesz przeliczyć: ");
Console.WriteLine("1 - Złoty");
Console.WriteLine("2 - Dolar Amerykański");
Console.WriteLine("3 - Euro");
Console.WriteLine("4 - Funt Brytyjski");
Console.Write("Twój wybór waluty, na którą chcesz przeliczyć: ");
double walP = Convert.ToDouble(Console.ReadLine());
switch (walP)
{
    case 1:
        Console.WriteLine("Wybrano walutę: Polski Złoty");
        break;
    case 2:
        Console.WriteLine("Wybrano walutę: Dolar Amerykański");
        break;
    case 3:
        Console.WriteLine("Wybrano walutę: Euro");
        break;
    case 4:
        Console.WriteLine("Wybrano walutę: Funt Brytyjski");
        break;
}
Console.WriteLine();
Console.Write("Podaj kwotę do przeliczenia: ");
double kwota = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double wynik = 0;
//double przelicznikZD = 4.44;
//double PrzelicznikZE = 4.68;
//double PrzelicznikZF = 5.47;
if (walB == 1)
{
    if (walP == 2)
    {
        wynik = kwota / 4.45;
    }
    else if (walP == 3)
    {
        wynik = kwota / 4.7;
    }
    else if (walP == 4)
    {
        wynik = kwota / 5.5;
    }
}
if (walB == 2)
{
    if (walP == 1)
    {
        wynik = kwota * 4.45;
    }
    else if (walP == 3)
    {
        wynik = kwota * 0.95;
    }
    else if (walP == 4)
    {
        wynik = kwota * 0.80;
    }
}
if (walB == 3)
{
    if (walP == 1)
    {
        wynik = kwota * 4.7;
    }
    else if (walP == 2)
    {
        wynik = kwota * 1.05;
    }
    else if (walP == 4)
    {
        wynik = kwota * 0.85;
    }
}
if (walB == 4)
{
    if (walP == 1)
    {
        wynik = kwota * 5.45;
    }
    else if (walP == 2)
    {
        wynik = kwota * 1.2;
    }
    else if (walP == 3)
    {
        wynik = kwota * 1.15;
    }
} 

if (walB == 1 && walP == 2)
{
    string w = "PLN";
    string z = walB.ToString(w);
    string x = "USD";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 1 && walP == 3)
{
    string w = "PLN";
    string z = walB.ToString(w);
    string x = "EUR";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 1 && walP == 4)
{
    string w = "PLN";
    string z = walB.ToString(w);
    string x = "GBP";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 2 && walP == 1)
{
    string w = "USD";
    string z = walB.ToString(w);
    string x = "PLN";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 2 && walP == 3)
{
    string w = "USD";
    string z = walB.ToString(w);
    string x = "EUR";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 2 && walP == 4)
{
    string w = "USD";
    string z = walB.ToString(w);
    string x = "GBP";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 3 && walP == 1)
{
    string w = "EUR";
    string z = walB.ToString(w);
    string x = "PLN";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 3 && walP == 2)
{
    string w = "EUR";
    string z = walB.ToString(w);
    string x = "USD";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 3 && walP == 4)
{
    string w = "EUR";
    string z = walB.ToString(w);
    string x = "GBP";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 4 && walP == 1)
{
    string w = "GBP";
    string z = walB.ToString(w);
    string x = "PLN";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 4 && walP == 2)
{
    string w = "GBP";
    string z = walB.ToString(w);
    string x = "USD";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}
else if (walB == 4 && walP == 3)
{
    string w = "GBP";
    string z = walB.ToString(w);
    string x = "EUR";
    string y = walP.ToString(x);
    Console.WriteLine("Po przeliczeniu {0} {1} na {2} wyszło {3} {4}", kwota, z, y, wynik, y);
}

Console.ReadKey();