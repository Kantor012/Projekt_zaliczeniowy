using System;

namespace Projekt_zaliczeniowy.Class
{
    public class Laptop : IT
    {
        //public static string[] przedmioty;
        public System.Text.StringBuilder sb = new System.Text.StringBuilder();
        public string rodzaj {get; set;}
        public int pojemnosc_dysk { get; set; }
        public Laptop()
        {
            System.Console.WriteLine("Jestem Laptop");
        }

        public void dodaj()
        {
            ilosc++;
            
            rodzaj = "Laptop";
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
            System.Console.WriteLine("Pojemnosc dysku [GB]:");
            pojemnosc_dysk = Convert.ToInt32(Console.ReadLine());
            sb.AppendJoin("  |  ", id, rodzaj, marka, model);
            sb.AppendLine("\n");
            sb.AppendLine(cpu);
            sb.AppendLine(gpu);
            sb.AppendLine(Convert.ToString(ram));
            sb.AppendLine(Convert.ToString(przekatna_ekranu));
            sb.AppendLine(Convert.ToString(pojemnosc_dysk));
            sb.AppendLine("\n\n");

            //przedmioty[id - 1] = sb.ToString();
            id++;
        }

        
    }
}
