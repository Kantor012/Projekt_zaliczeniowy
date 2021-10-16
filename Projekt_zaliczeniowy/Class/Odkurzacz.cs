using System;
namespace Projekt_zaliczeniowy.Class
{
    public class Odkurzacz : AGD
    {
        public int pojemnosc { get; set; }
        public int zasieg_pracy { get; set; }
        public Odkurzacz()
        {
            System.Console.WriteLine("Jestem konstruktorem");
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
            System.Console.WriteLine("Pojemność pojemnika/worka [L]:");
            pojemnosc = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("zasieg pracy [m]:");
            zasieg_pracy = Convert.ToInt32(Console.ReadLine());
            rodzaj_urz.Add("Odkurzacz");
        }
    }
}
