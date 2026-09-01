using System.Text;

Console.WriteLine("Hello, World!"); //mandatory!
//boolean slop
// x != y: Om båda är olika = true, båda samma = false
// x == y: Om båda är samma = true, båda olika = false
// bool Cmaster = 4 == 4 && 3 < 6; Om fyra är lika med fyra och tre är mindre än sex = true.
// bool Cmaster = 4 == 4 || 3 < 6; Om fyra är like med fyra ELLER tre är mindre än sex = true.
//bool Autumnssieur = 4 != 4;
Console.WriteLine("Fall or Autumn?");

string choice1 = Console.ReadLine();
choice1 = choice1.ToLower();
bool Autumnssieur = choice1 == "fall.";

if (choice1 == "fall.") //om sloppy är fall är sloppy fall
{
    Console.WriteLine("Not okay mister.");
}
else if (choice1 == "autumn.") //är sloppy inte fall utan autumn är sloppy autumn
{
    Console.WriteLine("Are you sure?");
}
else //är sloppy inte fall eller autumn är sloppy inte fall eller autumn
{
    Console.WriteLine("Cuck."); 
}

// string choice2 = Console.ReadLine();
// choice2 = choice2.ToLower();
if (Autumnssieur == false)
{
    string choice2 = Console.ReadLine();
    choice2 = choice2.ToLower();

    if (choice2 == "yes.") //sloppy är ja, sloppy = ja
    {
        Console.WriteLine("Hell yeah mister.");
    }
    else if (choice2 == "no.") //sloppy är inte ja, sloppy är nej, sloppy = nej
    {
        Console.WriteLine("Not okay mister.");
    }
    else //sloppy inte lika med ja eller nej, sloppy inte = ja eller nej
    {
        Console.WriteLine("Cuck.");
    }
}

Console.ReadLine();