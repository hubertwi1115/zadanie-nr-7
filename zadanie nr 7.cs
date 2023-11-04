using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj rok urodzenia:");
        int rokUrodzenia = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj imię i nazwisko:");
        string imieNazwisko = Console.ReadLine();

        Console.WriteLine("Podaj wiek:");
        int wiek = int.Parse(Console.ReadLine());
        if (wiek < 50)
        {
            Console.WriteLine("Wiek jest mniejszy niż 50 lat. Kończę program.");
            return; // Przerwij wykonanie programu
        }

       Console.WriteLine("Podaj miejsce urodzenia:");
        string miejsceUrodzenia = Console.ReadLine();

        Console.WriteLine($"Dane osobowe: {rokUrodzenia}, {imieNazwisko}, {wiek} lat, {miejsceUrodzenia}");
    }
}
