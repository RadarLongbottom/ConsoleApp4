// See https://aka.ms/new-console-template for more information

Console.WriteLine("Witaj w aplikacji przelicznika walut!!!");
Console.WriteLine("Wybierz walutę bazową: ");
Console.WriteLine("1 - Złoty");
Console.WriteLine("2 - Dolar Amerykański");
Console.WriteLine("3 - Euro");
Console.WriteLine("4 - Funt Brytyjski");
Console.Write("Twój wybór waluty bazowej: ");
var walB = Console.ReadLine();
Console.WriteLine();
switch (walB)
{
    case "1":
        Console.WriteLine("Wybrano walutę: Polski Złoty");
        break;
    case "2":
        Console.WriteLine("Wybrano walutę: Dolar Amerykański");
        break ;
    case "3":
        Console.WriteLine("Wybrano walutę: Euro");
        break;
    case "4":
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
var walP = Console.ReadLine();
switch (walP)
{
    case "1":
        Console.WriteLine("Wybrano walutę: Polski Złoty");
        break;
    case "2":
        Console.WriteLine("Wybrano walutę: Dolar Amerykański");
        break;
    case "3":
        Console.WriteLine("Wybrano walutę: Euro");
        break;
    case "4":
        Console.WriteLine("Wybrano walutę: Funt Brytyjski");
        break;
}
Console.WriteLine();
if (walB == "1")
{
    Convert.ToString(walB);
    walB = "Polski Złoty";
}
else if (walB == "2")
{
    Convert.ToString(walB);
    walB = "Dolar Amerykański";
}
else if (walB == "3")
{
    Convert.ToString(walB);
    walB = "Euro";
}
else if (walB == "4")
{
    Convert.ToString(walB);
    walB = "Funt Brytyjski";
}
if (walP == "1")
{
    Convert.ToString(walP);
    walP = "Polski Złoty";
}
else if (walP == "2")
{
    Convert.ToString(walP);
    walP = "Dolar Amerykański";
}
else if (walP == "3")
{
    Convert.ToString(walP);
    walP = "Euro";
}
else if (walP == "4")
{
    Convert.ToString(walP);
    walP = "Funt Brytyjski";
}

Console.WriteLine("Przeliczamy walutę: {0} na walutę: {1}", walB, walP);
Console.WriteLine();
Console.Write("Podaj kwotę jaką chcesz przeliczyć: ");
double kwota = 15;
Console.WriteLine("{0} {1} to {3}", kwota, walB, walP);
Console.ReadKey(); 