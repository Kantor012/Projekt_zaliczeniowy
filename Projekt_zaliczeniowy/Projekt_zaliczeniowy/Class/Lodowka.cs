using System;
namespace Projekt_zaliczeniowy.Class
{
    public class Lodowka : AGD
    {
        public System.Text.StringBuilder sb = new System.Text.StringBuilder();
        public string rodzaj { get; set; }
        public int poziom_halasu { get; set; }
        public int roczne_zuz_pr_kwh { get; set; }
        public Lodowka()
        {
           // System.Console.WriteLine("Jestem Lodowka");
        }

        public void dodaj()
        {
            ilosc++;
            
            rodzaj = "Lodowka";
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

            Data.dodaj_lodowka(id, rodzaj, producent, klasa_energetyczna, moc, waga, poziom_halasu, roczne_zuz_pr_kwh);

            sb.AppendJoin("  |  ","id: "+ id,"Typ: "+ rodzaj,"Producent: "+ producent);
            sb.AppendLine("\n");
            sb.AppendLine(Convert.ToString("Klasa energetyczna: "+klasa_energetyczna));
            sb.AppendLine(Convert.ToString("Moc: "+moc));
            sb.AppendLine(Convert.ToString("Waga: "+waga));
            sb.AppendLine(Convert.ToString("Poziom halasu: "+poziom_halasu));
            sb.AppendLine(Convert.ToString("Roczne zuzycie pradu: "+roczne_zuz_pr_kwh));
            sb.AppendLine("\n\n");
            id++;
        }

    }
}
