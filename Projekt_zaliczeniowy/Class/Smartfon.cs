using System;
using System.Text.RegularExpressions;

namespace Projekt_zaliczeniowy.Class
{
    public class Smartfon : IT
    {
        private string rodzaj { get; set; }
        private int rom { get; set; }
        private bool _5G { get; set; }
        public Smartfon()
        {
            //  System.Console.WriteLine("Jestem Smartfon");
        }
        public void dodaj()
        {
            var input = "";
            ilosc++;
            System.Console.WriteLine("Marka:");
            marka = System.Console.ReadLine();
            if (marka == "") marka = "undefined";

            System.Console.WriteLine("Model:");
            model = System.Console.ReadLine();
            if (model == "") model = "undefined";

            System.Console.WriteLine("CPU:");
            cpu = System.Console.ReadLine();
            if (cpu == "") cpu = "undefined";

            System.Console.WriteLine("GPU:");
            gpu = System.Console.ReadLine();
            if (gpu == "") gpu = "undefined";

            System.Console.WriteLine("RAM [GB]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) ram = int.Parse(input);
            else ram = 0;

            System.Console.WriteLine("Przekatna ekranu [\"]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) przekatna_ekranu = int.Parse(input);
            else przekatna_ekranu = 0;

            System.Console.WriteLine("Pamiec wbudowana [GB]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) rom = int.Parse(input);
            else rom = 0;

            System.Console.WriteLine("Czy jest przystosowany do sieci 5G? (1- tak, 0- nie)");

            do
            {
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^\d+$") == true)
                {
                    if (input != "1" && input != "0") _5G=false;
                    else if (input == "1") _5G = true;
                    else if (input == "0") _5G = false;
                }
                else
                    Console.WriteLine("Wprowadzony tekst nie jest liczba. Wprowadz liczbe ponownie.");
            } while (Regex.IsMatch(input, @"^\d+$") == false || (input != "1" && input != "0"));
            rodzaj = "Smartfon";

            Data.dodaj_smartfon(id, rodzaj, marka, model, cpu, gpu, ram, przekatna_ekranu, rom, _5G);
            id++;
        }
    }
}