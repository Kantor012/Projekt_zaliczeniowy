using System;
using System.Text.RegularExpressions;

namespace Projekt_zaliczeniowy.Class
{
    public class Smartfon : IT
    {
        public System.Text.StringBuilder sb = new System.Text.StringBuilder();
        public string rodzaj { get; set; }
        public int rom { get; set; }
        public bool _5G { get; set; }
        //string input;
        public Smartfon()
        {
          //  System.Console.WriteLine("Jestem Smartfon");
        }

        public void dodaj()
        {
            ilosc++;
            System.Console.WriteLine("Marka:");
            marka = System.Console.ReadLine();
            System.Console.WriteLine("Model:");
            model = System.Console.ReadLine();
            System.Console.WriteLine("CPU:");
            cpu = System.Console.ReadLine();
            System.Console.WriteLine("GPU:");
            gpu = System.Console.ReadLine();
            System.Console.WriteLine("RAM [GB]:");
            ram = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Przekatna ekranu [\"]:");
            przekatna_ekranu = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Pamiec wbudowana [GB]:");
            rom = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Czy jest przystosowany do sieci 5G? (1- tak, 0- nie)");
            var input="";
            do { 
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^\d+$") == true)
                {

                    if (input != "1" && input != "0") Console.WriteLine("Wprowadzona liczba jest bledna, wprowadz liczbę ponownie.");
                    else if (input == "1") _5G = true;
                    else if (input == "0") _5G = false;
                } 
                else
                    Console.WriteLine("Wprowadzony tekst nie jest liczba. Wprowadz liczbe ponownie.");
            } while (Regex.IsMatch(input, @"^\d+$") == false || (input != "1" && input != "0"));
            rodzaj = "Smartfon";

            Data.dodaj_smartfon(id, rodzaj, marka, model, cpu, gpu, ram, przekatna_ekranu, rom, _5G);

            sb.AppendJoin("  |  ","id: "+ id,"Typ: "+ rodzaj,"Marka: "+ marka,"Model: "+ model);
            sb.AppendLine("\n");
            sb.AppendLine("Procesor: "+cpu);
            sb.AppendLine("Karta graficzna: "+gpu);
            sb.AppendLine(Convert.ToString("Pamiec RAM: "+ram));
            sb.AppendLine(Convert.ToString("Przekatna ekranu: "+przekatna_ekranu));
            sb.AppendLine(Convert.ToString("Pamiec wbudowana: "+rom));
            sb.AppendLine(Convert.ToString("Czy obsluguje 5G: "+_5G));
            sb.AppendLine("\n\n");
            id++;
        }
    }
}