using System;
using System.Text.RegularExpressions;
namespace Projekt_zaliczeniowy.Class
{
    public class Lodowka : AGD
    {
        private string rodzaj { get; set; }
        private int poziom_halasu { get; set; }
        private int roczne_zuz_pr_kwh { get; set; }
        public Lodowka()
        {
            // System.Console.WriteLine("Jestem Lodowka");
        }

        public void dodaj()
        {
            var input = "";
            ilosc++;

            rodzaj = "Lodowka";
            System.Console.WriteLine("Producent:");
            producent = System.Console.ReadLine();
            if (producent == "") producent = "undefined";

            System.Console.WriteLine("Klasa energetyczna:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z0-9]+$") == true) klasa_energetyczna = input[0];
            else klasa_energetyczna = '0';

            System.Console.WriteLine("Moc [W]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[0-9]+$") == true) moc = int.Parse(input);
            else moc = 0;

            System.Console.WriteLine("Waga [kg]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) waga = int.Parse(input);
            else waga = 0;

            System.Console.WriteLine("Poziom halasu [dB]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) poziom_halasu = int.Parse(input);
            else poziom_halasu = 0;

            System.Console.WriteLine("Roczne zuzycie pradu [kWh]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) roczne_zuz_pr_kwh = int.Parse(input);
            else roczne_zuz_pr_kwh = 0;

            Data.dodaj_lodowka(id, rodzaj, producent, klasa_energetyczna, moc, waga, poziom_halasu, roczne_zuz_pr_kwh);
            id++;
        }

    }
}
