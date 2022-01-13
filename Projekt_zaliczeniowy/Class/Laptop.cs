using System;
using System.Text.RegularExpressions;

namespace Projekt_zaliczeniowy.Class
{
    public class Laptop : IT
    {
        private string rodzaj { get; set; }
        private int pojemnosc_dysk { get; set; }
        public Laptop()
        {
            //  System.Console.WriteLine("Jestem Laptop");
        }

        public void dodaj()
        {
            var input = "";
            ilosc++;

            rodzaj = "Laptop";

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

            System.Console.WriteLine("Pojemnosc dysku [GB]:");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d+$") == true) pojemnosc_dysk = int.Parse(input);
            else pojemnosc_dysk = 0;

            Data.dodaj_laptop(id, rodzaj, marka, model, cpu, gpu, ram, przekatna_ekranu, pojemnosc_dysk);

            id++;
        }


    }
}
