//Console.WriteLine("Hello, World!");
bool Yurinator = true;
bool HawkTuah = true;
//boolean slop
// x != y: Om båda är olika = true, båda samma = false
// x == y: Om båda är samma = true, båda olika = false
// bool Cmaster = 4 == 4 && 3 < 6; Om fyra är lika med fyra och tre är mindre än sex = true.
// bool Cmaster = 4 == 4 || 3 < 6; Om fyra är like med fyra ELLER tre är mindre än sex = true.
//bool Autumnssieur = 4 != 4;
//bool Autumnssieur = choice1 == "fall.";
while (Yurinator == true) // Om semicolon = while true gör INTE
{
int ForbiddenYaoi = 0;
Console.WriteLine($"Points: {ForbiddenYaoi}");

Console.WriteLine("Is liking men as a man considered gay?");
string Blans = Console.ReadLine();
Blans = Blans.ToLower();
bool Boolean = Blans == "yes.";



if (ForbiddenYaoi < 2)
{

    if (Blans == "yes.")
    {
        Console.WriteLine("Trick question.");
        ForbiddenYaoi = ForbiddenYaoi + 1;  //Lättare sätt: ForbiddenYaoi += 1;
        Console.WriteLine($"Points: {ForbiddenYaoi}");
    }

    else if (Blans == "no.")
    {
        Console.WriteLine("Trick question.");
        ForbiddenYaoi = ForbiddenYaoi + 1;  //Lättare sätt: ForbiddenYaoi += 1;
        Console.WriteLine($"Points: {ForbiddenYaoi}");
    }

    else
    {
        Console.WriteLine("Why so skibidious? Honk honk honk.");
        ForbiddenYaoi = ForbiddenYaoi - 67;
    }

    if (Boolean == true)
    {
    Console.WriteLine("Was Nukitashi anime of the year 2025?");
    }
        string Cuckaroni = Console.ReadLine();
        Cuckaroni = Cuckaroni.ToLower();


    if (Cuckaroni == "yes.")
    {
        Console.WriteLine("False but it is in our hearts.");
        Console.WriteLine($"Points: {ForbiddenYaoi}");
        Console.WriteLine("You're not good enough. Restart? Y/N");
        string Marketpiler = Console.ReadLine();
        if (Marketpiler == "y")
        {
            Console.Clear();
            HawkTuah = true;
        }
        else if (Marketpiler == "n")
        {
            Yurinator = false;
            HawkTuah = true;
        }
    }

    else if (Cuckaroni == "no.")
    {
        Console.WriteLine("The sad truth kappapenis");
        ForbiddenYaoi = ForbiddenYaoi + 1;  //Lättare sätt: ForbiddenYaoi += 1;
        Console.WriteLine($"Points: {ForbiddenYaoi}");
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Hawk tuius, you suck balls. Retry? Y/N");
        string Marketpiler = Console.ReadLine();
        if (Marketpiler == "y")
        {
            Console.Clear();
            HawkTuah = true;
        }
        else if (Marketpiler == "n")
        {
            Yurinator = false;
            HawkTuah = true;
        }
    }

}
if (ForbiddenYaoi == 2)
{
    Console.Clear();
    Console.WriteLine("You are very sigma, well done my ohi-ius cabbage. Retry? Y/N");
    string CheesePizza = Console.ReadLine();
    CheesePizza = CheesePizza.ToLower();
    if (CheesePizza == "y")
    {
        Console.Clear();
        HawkTuah = true;
    }
    else if (CheesePizza == "n")
    { 
        Yurinator = false;
        HawkTuah = true;
    }
}
if (HawkTuah == false)
{
Console.ReadLine();
}
}