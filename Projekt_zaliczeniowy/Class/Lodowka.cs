using System;
namespace Projekt_zaliczeniowy.Class
{
    public class Lodowka : AGD
    {
        public int poziom_halasu { get; set; }
        public int roczne_zuz_pr_kwh { get; set; }
        public Lodowka()
        {
            System.Console.WriteLine("Jestem Lodowka");
        }

        public void dodaj()
        {
            ilosc++;
            id++;
            //rodzaj = System.Console.ReadLine();
            System.Console.WriteLine("Producent:");
            producent = System.Console.ReadLine();
            System.Console.WriteLine("Klasa energetyczna:");
            klasa_energetyczna = Convert.ToChar(Console.ReadLine());
            System.Console.WriteLine("Moc [W]:");
            moc = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Waga [kg]:");
            waga = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Poziom halasu [dB]:");
            poziom_halasu = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Roczne zuzycie pradu [kWh]:");
            roczne_zuz_pr_kwh = Convert.ToInt32(Console.ReadLine()); 
            rodzaj_urz.Add("Lodowka");
        }

    }
}
