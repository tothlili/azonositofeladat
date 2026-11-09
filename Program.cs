File.WriteAllText("belepesek.txt", "");
while (true)
{
    string belepesek=File.ReadAllText("belepesek.txt");
    string[] sorok=File.ReadAllLines("belepesek.txt");
    
    Console.Write("1. Személy belépés\n2. Jármű belépés\n3. keresés\n");
    string valasz = Console.ReadLine();
    if (valasz == "1")
    {
        Console.Write("\nSzemély neve: ");
        string nev= Console.ReadLine();
        Console.Write("\nSzemély igazolvány száma: ");
        string igazolvany = Console.ReadLine();
        File.AppendAllText("belepesek.txt", $"{DateTime.Now};{nev};{igazolvany};\n");
    }
    else if (valasz == "2")
    {
        Console.Write("\nJármű márkája: ");
        string marka = Console.ReadLine();
        Console.Write("\nJármű típusa: ");
        string tipus = Console.ReadLine();
        Console.Write("\nJármű színe: ");
        string szin = Console.ReadLine();
        Console.Write("\nJármű rendszáma: ");
        string rendszam = Console.ReadLine();
        File.AppendAllText("belepesek.txt", $"{DateTime.Now};{marka};{tipus};{szin};{rendszam};\n");
    }

    else if (valasz == "3")
    {
        Console.Write("Keresés: ");
        string keres= Console.ReadLine();
        Console.Write("Mi alapján fogsz keresni: 1. Személy neve alapján | 2. Jármű rendszáma alapján | 3. Jármű típusa alapáján | 4. Jermű márkája alapján");
        string keresvalasz=Console.ReadLine();
        foreach(string i in sorok)
        {
            if (i.Split(";").Count() == 4 && keresvalasz=="1") {
                if (i.Split(";")[1] == keres)
                {
                    Console.Write($"{i}\n");
                }
            }
            if (i.Split(";").Count() == 6 && keresvalasz == "2")
            {
                if (i.Split(";")[4] == keres)
                {
                    Console.Write($"{i}\n");
                }
            }
            if (i.Split(";").Count() == 6 && keresvalasz == "3")
            {
                if (i.Split(";")[2] == keres)
                {
                    Console.Write($"{i}\n");
                }
            }
            if(i.Split(";").Count() == 6 && keresvalasz == "4")
            {
                if (i.Split(";")[1] == keres)
                {
                    Console.Write($"{i}\n");
                }
            }
        }
    }
    else
    {
        break;
    }
}