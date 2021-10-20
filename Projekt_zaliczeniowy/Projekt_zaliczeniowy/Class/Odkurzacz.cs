using System;
namespace Projekt_zaliczeniowy.Class
{
    public class Odkurzacz : AGD
    {
        public System.Text.StringBuilder sb = new System.Text.StringBuilder();
        public string rodzaj { get; set; }
        public int pojemnosc { get; set; }
        public int zasieg_pracy { get; set; }
        public Odkurzacz()
        {
           // System.Console.WriteLine("Jestem konstruktorem");
        }

        public void dodaj()
        {
            ilosc++;
            //id++;
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
            rodzaj = "Odkurzacz";

            Data.dodaj_odkurzacz(id, rodzaj, producent, klasa_energetyczna, moc, waga, pojemnosc, zasieg_pracy);

            sb.AppendJoin("  |  ","id: "+ id,"Typ: "+ rodzaj, "Producent: "+ producent);
            sb.AppendLine("\n");
            sb.AppendLine(Convert.ToString("Klasa energetyczna: "+klasa_energetyczna));
            sb.AppendLine(Convert.ToString("Moc: "+moc));
            sb.AppendLine(Convert.ToString("Waga: "+waga));
            sb.AppendLine(Convert.ToString("Pojemność pojemnika/worka: "+pojemnosc));
            sb.AppendLine(Convert.ToString("Zasieg pracy: "+zasieg_pracy));
            sb.AppendLine("\n\n");
            id++;
        }
    }
}
