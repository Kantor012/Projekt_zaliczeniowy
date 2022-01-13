using System;
using System.Text.RegularExpressions;
namespace Projekt_zaliczeniowy.Class
{
    public class Odkurzacz : AGD
    {
        private string rodzaj { get; set; }
        private int pojemnosc { get; set; }
        private int zasieg_pracy { get; set; }
        public Odkurzacz()
        {
            // System.Console.WriteLine("Jestem konstruktorem");
        }
        public void dodaj()
        {
            var input = "";
            ilosc++;
            System.Console.WriteLine("Producent:");
            producent = System.Console.ReadLine();
            if (producent == "") producent = "undefined";

            System.Console.WriteLine("Klasa energetyczna:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z0-9]+$") == true) klasa_energetyczna = input[0];
            else klasa_energetyczna = '0';

            System.Console.WriteLine("Moc [W]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) moc = int.Parse(input);
            else moc = 0;

            System.Console.WriteLine("Waga [kg]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) waga = int.Parse(input);
            else waga = 0;

            System.Console.WriteLine("Pojemność pojemnika/worka [L]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) pojemnosc = int.Parse(input);
            else pojemnosc = 0;

            System.Console.WriteLine("zasieg pracy [m]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) zasieg_pracy = int.Parse(input);
            else zasieg_pracy = 0;
            rodzaj = "Odkurzacz";

            Data.dodaj_odkurzacz(id, rodzaj, producent, klasa_energetyczna, moc, waga, pojemnosc, zasieg_pracy);
            id++;
        }
    }
}
