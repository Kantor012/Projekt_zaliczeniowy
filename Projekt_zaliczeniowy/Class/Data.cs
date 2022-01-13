using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace Projekt_zaliczeniowy.Class
{
    public class Data : Program
    {
        private static System.Data.DataSet DataS;
        private static List<string> opcje1 = new List<string>
        {
            "Laptop", "Smartfon", "Lodowka", "Odkurzacz", "Wszystko", "Powrót"
        };
        bool done_opcje = false;


        public void DataCreate()
        {
            Urzadzenia();
            Database();
        }

        private void Urzadzenia()
        {
            DataTable table1 = new DataTable("Urzadzenia");
            DataColumn column;

            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "ID";
                column.ReadOnly = true;
                column.Unique = true;
                table1.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Typ";
                column.ReadOnly = false;
                column.Unique = false;
                table1.Columns.Add(column);
            }
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table1.Columns["id"];
            table1.PrimaryKey = PrimaryKeyColumns;
            DataS = new DataSet();
            DataS.Tables.Add(table1);

        }

        private void Database()
        {
            DataTable table = new DataTable("Table");
            DataColumn column;
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "id";
                column.AutoIncrement = true;
                column.Caption = "ID";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Rodzaj";
                column.AutoIncrement = false;
                column.Caption = "Rodzaj";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Marka";
                column.AutoIncrement = false;
                column.Caption = "Marka";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Model";
                column.AutoIncrement = false;
                column.Caption = "Model";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "CPU";
                column.AutoIncrement = false;
                column.Caption = "CPU";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "GPU";
                column.AutoIncrement = false;
                column.Caption = "GPU";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "RAM";
                column.AutoIncrement = false;
                column.Caption = "RAM [GB]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Przekatna";
                column.AutoIncrement = false;
                column.Caption = "Przekatna ekranu \"";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Pojemnosc";
                column.AutoIncrement = false;
                column.Caption = "Pojemnosc [GB]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Boolean");
                column.ColumnName = "5G";
                column.AutoIncrement = false;
                column.Caption = "5G";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Producent";
                column.AutoIncrement = false;
                column.Caption = "Producent";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Char");
                column.ColumnName = "Klasa_ene";
                column.AutoIncrement = false;
                column.Caption = "Klasa energetyczna";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Moc";
                column.AutoIncrement = false;
                column.Caption = "Moc [W]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Waga";
                column.AutoIncrement = false;
                column.Caption = "Waga [kg]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Halas";
                column.AutoIncrement = false;
                column.Caption = "Poziom halasu [dB]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Prad";
                column.AutoIncrement = false;
                column.Caption = "Roczne zuz. pradu [kWh]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            {
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Pojemnosc_agd";
                column.AutoIncrement = false;
                column.Caption = "Pojemnosc pojemnika/worka [L]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            column = new DataColumn();
            { 
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Zasieg";
                column.AutoIncrement = false;
                column.Caption = "Zasieg pracy [m]";
                column.ReadOnly = false;
                column.Unique = false;
                table.Columns.Add(column);
            }
            DataS.Tables.Add(table);
        }

        protected static void dodaj_laptop(int id, string rodz, string marka, string model, string cpu, string gpu, int ram, int przekatna, int pojemnosc)
        {

            DataTable table = DataS.Tables["Table"];
            DataRow row = table.NewRow();
            row["Rodzaj"] = rodz;
            row["Marka"] = marka;
            row["Model"] = model;
            row["CPU"] = cpu;
            row["GPU"] = gpu;
            if (ram > int.MaxValue) ram = int.MaxValue;
            row["RAM"] = ram;
            if (przekatna > int.MaxValue) przekatna = int.MaxValue;
            row["Przekatna"] = przekatna;
            if (pojemnosc > int.MaxValue) pojemnosc = int.MaxValue;
            row["Pojemnosc"] = pojemnosc;
            table.Rows.Add(row);
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = false;
            int counter = 1;
            foreach (DataRow dr in table.Rows)
            {
                dr["id"] = counter++;
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = true;
        }

        protected static void dodaj_smartfon(int id, string rodz, string marka, string model, string cpu, string gpu, int ram, int przekatna, int pojemnosc, bool _5G)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "IT";
            DataTable table = DataS.Tables["Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row["Rodzaj"] = rodz;
            row["Marka"] = marka;
            row["Model"] = model;
            row["CPU"] = cpu;
            row["GPU"] = gpu;
            if (ram > int.MaxValue) ram = int.MaxValue;
            row["RAM"] = ram;
            if (przekatna > int.MaxValue) przekatna = int.MaxValue;
            row["Przekatna"] = przekatna;
            if (pojemnosc > int.MaxValue) pojemnosc = int.MaxValue;
            row["Pojemnosc"] = pojemnosc;
            row["5G"] = _5G;
            table.Rows.Add(row);
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = false;
            int counter = 1;
            foreach (DataRow dr in table.Rows)
            {
                dr["id"] = counter++;
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = true;
        }

        protected static void dodaj_lodowka(int id, string rodz, string producent, char klasa, int moc, int waga, int halas, int prad)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "AGD";
            DataTable table = DataS.Tables["Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row["Rodzaj"] = rodz;
            row["Producent"] = producent;
            row["Klasa_ene"] = klasa;
            if (moc > int.MaxValue) moc = int.MaxValue;
            row["Moc"] = moc;
            if (waga > int.MaxValue) waga = int.MaxValue;
            row["Waga"] = waga;
            if (halas > int.MaxValue) halas = int.MaxValue;
            row["Halas"] = halas;
            if (prad > int.MaxValue) prad = int.MaxValue;
            row["Prad"] = prad;
            table.Rows.Add(row);
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = false;
            int counter = 1;
            foreach (DataRow dr in table.Rows)
            {
                dr["id"] = counter++;
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = true;
        }

        protected static void dodaj_odkurzacz(int id, string rodz, string producent, char klasa, int moc, int waga, int pojemnosc, int zasieg)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "AGD";
            DataTable table = DataS.Tables["Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row["Rodzaj"] = rodz;
            row["Producent"] = producent;
            row["Klasa_ene"] = klasa;
            if (moc > int.MaxValue) moc = int.MaxValue;
            row["Moc"] = moc;
            if (waga > int.MaxValue) waga = int.MaxValue;
            row["Waga"] = waga;
            if (pojemnosc > int.MaxValue) pojemnosc = int.MaxValue;
            row["Pojemnosc_agd"] = pojemnosc;
            if (zasieg > int.MaxValue) zasieg = int.MaxValue;
            row["Zasieg"] = zasieg;
            table.Rows.Add(row);
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = false;
            int counter = 1;
            foreach (DataRow dr in table.Rows)
            {
                dr["id"] = counter++;
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = true;
        }

        private static void usun(string table1, string v1, string v2, string v3)
        {
            DataTable table = DataS.Tables[table1];
            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = table.Rows[i];
                if (dr[0].ToString() == v1 && dr[2].ToString() == v2 && dr[3].ToString() == v3)
                {
                    Console.WriteLine("{0} {1} {2} został pomyślnie usuniety\nWciśnij dowolny przycisk.", dr[1], dr[2], dr[3]); Console.ReadKey();
                    dr.Delete();
                }
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = false;
            int counter = 1;
            foreach (DataRow row in table.Rows)
            {
                row["id"] = counter++;
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = true;
        }

        private static void usun(string table1, string v1, string v2)
        {
            DataTable table = DataS.Tables[table1];
            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = table.Rows[i];
                if (dr[0].ToString() == v1 && dr[10].ToString() == v2)
                {
                    Console.WriteLine("{0} {1} został pomyślnie usuniety", dr[1], dr[10]); dr.Delete(); Console.ReadKey();
                }
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = false;
            int counter = 1;
            foreach (DataRow row in table.Rows)
            {
                row["id"] = counter++;
            }
            table.AcceptChanges();
            table.Columns["id"].ReadOnly = true;
        }

        private static void drop_db()
        {
            Console.WriteLine("Ta sytuacja jest nieodwracalna, czy na pewno chcesz to zrobić? T/N");
            string wybor = Console.ReadLine();
            if (wybor == "T" || wybor == "t")
            {
                DataTable table = DataS.Tables["Table"];
                for (int i = table.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = table.Rows[i];
                    dr.Delete();
                }
                table.AcceptChanges();
                Console.WriteLine("Baza danych została wyczyszczona.\nWciśnij dowolny przycisk...");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Baza danych nie zostanie usunięta.\nWciśnij dowolny przycisk...");
        }

        public void wyswietl()
        {
            DataTable table = DataS.Tables["Table"];
            Console.Clear();
            foreach (DataRow row in table.Rows)
            {
                if (row[1].ToString() == "Laptop" || row[1].ToString() == "Smartfon")
                {
                    string id = row["id"].ToString();
                    string rodzaj = row["Rodzaj"].ToString();
                    string marka = row["Marka"].ToString();
                    string model = row["Model"].ToString();
                    string cpu = row["CPU"].ToString();
                    string gpu = row["GPU"].ToString();
                    string ram = row["RAM"].ToString();
                    string przekatna = row["Przekatna"].ToString();
                    string pojemnosc = row["Pojemnosc"].ToString();
                    Console.WriteLine("\n\n" + id + ", " + rodzaj + ", " + marka + ", " + model);
                    Console.WriteLine("cpu: {0}\ngpu: {1}\nram: {2}\nprzekatna: {3}\npojemnosc w GB: {4}", cpu, gpu, ram, przekatna, pojemnosc);
                    if (rodzaj == "Smartfon")
                    {
                        string _5G = row[9].ToString();
                        Console.WriteLine("5G: {0}", _5G);
                    }
                }
                else
                {
                    string id = row[0].ToString();
                    string rodzaj = row[1].ToString();
                    string producent = row[10].ToString();
                    string klasa_ene = row[11].ToString();
                    string moc = row[12].ToString();
                    string waga = row[13].ToString();
                    string halas = row[14].ToString();
                    string prad = row[15].ToString();
                    string pojemnosc = row[16].ToString();
                    string zasieg = row[17].ToString();
                    Console.WriteLine("\n\n" + id + ", " + rodzaj + ", " + producent);
                    if (rodzaj == "Lodowka")
                    {
                        Console.WriteLine("Klasa energetyczna: {0}\nMoc [W]: {1}\nWaga [kg]: {2}\nHalas [dB]: {3}\nZuzycie pradu w ciagu roku [kWh]: {4}", klasa_ene, moc, waga, halas, prad);
                    }
                    else if (rodzaj == "Odkurzacz")
                    {
                        Console.WriteLine("Klasa energetyczna: {0}\nMoc [W]: {1}\nWaga [kg]: {2}\nPojemnosc pojemnika/worka [L]: {3}\nZasieg pracy [m]: {4}", klasa_ene, moc, waga, pojemnosc, zasieg);
                    };
                }
            }
            Console.WriteLine("\n\nWcisnij dowolny przycisk...");
            Console.ReadKey();
            Console.Clear();
        }

        public void znajdz()
        {
            DataTable table = DataS.Tables["Table"];
            Console.Clear();
            int zaznaczone_opcje = 0;
            done_opcje = false;
            int wybor = 0;
            while (!done_opcje)
            {
                Console.Clear();
                Console.WriteLine("Co chcesz wyswietlic?");
                for (wybor = 0; wybor < opcje1.Count; wybor++)
                {
                    if (zaznaczone_opcje == wybor) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                    Console.WriteLine("{0} {1}",
                        wybor + 1,
                        opcje1[wybor]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        zaznaczone_opcje = Math.Max(0, zaznaczone_opcje - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        zaznaczone_opcje = Math.Min(opcje1.Count - 1, zaznaczone_opcje + 1);
                        break;
                    case ConsoleKey.Enter:
                        done_opcje = true;
                        break;
                }
                if (!done_opcje)
                    Console.CursorTop = Console.CursorTop - opcje1.Count;
                else
                {
                    Console.Clear();
                }
            }
            bool done = false;
            int zaznaczone = 0;
            int i = 0;
            switch (zaznaczone_opcje + 1)
            {
                case 1:
                    {
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {
                            if (row[1].ToString() == "Laptop") { i++; wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1); }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Laptop {0} {1} znajduje sie na {2} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][2],
                                        table.Rows[wiersze_zgodne[j]][3],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][2] + " " + table.Rows[wiersze_zgodne[zaznaczone]][3] +
                                    "\nCPU: " + table.Rows[wiersze_zgodne[zaznaczone]][4] +
                                    "\nGPU: " + table.Rows[wiersze_zgodne[zaznaczone]][5] +
                                    "\nRAM: " + table.Rows[wiersze_zgodne[zaznaczone]][6] +
                                    "\nPrzekatna ekranu: " + table.Rows[wiersze_zgodne[zaznaczone]][7] +
                                    "\nPojemnosc dysku: " + table.Rows[wiersze_zgodne[zaznaczone]][8]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.WriteLine("\n\n\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                        }
                        else { Console.WriteLine("Niestety nie ma zadnych laptopow w bazie.\nWciśnij dowolny przycisk..."); Console.ReadKey(); }
                        break;
                    }
                case 2:
                    {
                        zaznaczone = 0;
                        done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {

                            if (row[1].ToString() == "Smartfon")
                            {
                                i += 1;
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Smartfon {0} {1} znajduje sie na {2} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][2],
                                        table.Rows[wiersze_zgodne[j]][3],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][2] + " " + table.Rows[wiersze_zgodne[zaznaczone]][3] +
                                    "\nCPU: " + table.Rows[wiersze_zgodne[zaznaczone]][4] +
                                    "\nGPU: " + table.Rows[wiersze_zgodne[zaznaczone]][5] +
                                    "\nRAM: " + table.Rows[wiersze_zgodne[zaznaczone]][6] +
                                    "\nPrzekatna ekranu: " + table.Rows[wiersze_zgodne[zaznaczone]][7] +
                                    "\nPamiec wbudowana: " + table.Rows[wiersze_zgodne[zaznaczone]][8] +
                                    "\n5G: " + table.Rows[wiersze_zgodne[zaznaczone]][9]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.WriteLine("\n\n\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych smartfonow... \nWcisnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        zaznaczone = 0;
                        done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {

                            if (row[1].ToString() == "Lodowka")
                            {
                                i += 1;
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Lodowka {0} znajduje sie na {1} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][10],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][10] +
                                    "\nKlasa energetyczna: " + table.Rows[wiersze_zgodne[zaznaczone]][11] +
                                    "\nMoc: " + table.Rows[wiersze_zgodne[zaznaczone]][12] +
                                    "\nWaga: " + table.Rows[wiersze_zgodne[zaznaczone]][13] +
                                    "\nPoziom halasu: " + table.Rows[wiersze_zgodne[zaznaczone]][14] +
                                    "\nRoczne zuzycie pradu: " + table.Rows[wiersze_zgodne[zaznaczone]][15]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.WriteLine("\n\n\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych lodowek.\nWciśnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        zaznaczone = 0;
                        done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {

                            if (row[1].ToString() == "Odkurzacz")
                            {
                                i += 1;
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Odkurzacz {0} znajduje sie na {1} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][10],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][10] +
                                    "\nKlasa energetyczna: " + table.Rows[wiersze_zgodne[zaznaczone]][11] +
                                    "\nMoc: " + table.Rows[wiersze_zgodne[zaznaczone]][12] +
                                    "\nWaga: " + table.Rows[wiersze_zgodne[zaznaczone]][13] +
                                    "\nPojemnosc: " + table.Rows[wiersze_zgodne[zaznaczone]][16] +
                                    "\nZasieg: " + table.Rows[wiersze_zgodne[zaznaczone]][17]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.WriteLine("\n\n\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych odkurzaczy.\nWciśnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        wyswietl();
                        Console.WriteLine("\n\n\nAby wrócić do głównego menu wciśnij dowolny przycisk...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrocisz teraz do glownego menu.\nWciśnij dowolny przycisk...");
                        Console.ReadKey();
                        break;
                    }
            }

        }

        public void usun()
        {
            Console.Clear();
            DataTable table = DataS.Tables["Table"];
            int zaznaczone_opcje = 0;
            done_opcje = false;
            int wybor = 0;
            while (!done_opcje)
            {
                for (wybor = 0; wybor < opcje1.Count; wybor++)
                {
                    if (zaznaczone_opcje == wybor) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                    Console.WriteLine("{0} {1}",
                        wybor + 1,
                        opcje1[wybor]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        zaznaczone_opcje = Math.Max(0, zaznaczone_opcje - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        zaznaczone_opcje = Math.Min(opcje1.Count - 1, zaznaczone_opcje + 1);
                        break;
                    case ConsoleKey.Enter:
                        done_opcje = true;
                        break;
                }
                if (!done_opcje)
                    Console.CursorTop = Console.CursorTop - opcje1.Count;
                else
                {
                    Console.Clear();
                }
            }
            int i = 0;
            Console.Clear();
            Console.WriteLine("Czy chcesz utworzyc kopie zapasowa bazy danych przed wykonaniem tej operacji? T/N");
            string backup = Console.ReadLine();
            if (backup == "T" || backup == "t")
            {
                zapisz_backup();
            }
            Console.Clear();
            switch (zaznaczone_opcje + 1)
            {
                case 1:
                    {
                        int zaznaczone = 0;
                        bool done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {
                            if (row[1].ToString() == "Laptop")
                            {
                                i += 1;
                                //Console.WriteLine("Laptop {0} {1} znajduje się na {2} pozycji.", row[2].ToString(), row[3].ToString(), row[0].ToString());
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Laptop {0} {1} znajduje sie na {2} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][2],
                                        table.Rows[wiersze_zgodne[j]][3],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][2] + " " + table.Rows[wiersze_zgodne[zaznaczone]][3] +
                                    "\nCPU: " + table.Rows[wiersze_zgodne[zaznaczone]][4] +
                                    "\nGPU: " + table.Rows[wiersze_zgodne[zaznaczone]][5] +
                                    "\nRAM: " + table.Rows[wiersze_zgodne[zaznaczone]][6] +
                                    "\nPrzekatna ekranu: " + table.Rows[wiersze_zgodne[zaznaczone]][7] +
                                    "\nPojemnosc dysku: " + table.Rows[wiersze_zgodne[zaznaczone]][8]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Urządzenie zostało usunięte.\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }

                            string wybor1 = "Table";

                            string id = table.Rows[wiersze_zgodne[zaznaczone]][0].ToString();

                            string marka = table.Rows[wiersze_zgodne[zaznaczone]][2].ToString();

                            string model = table.Rows[wiersze_zgodne[zaznaczone]][3].ToString();
                            usun(wybor1, id, marka, model);
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych laptopow.\nWciśnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        int zaznaczone = 0;
                        bool done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {

                            if (row[1].ToString() == "Smartfon")
                            {
                                i += 1;
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Smartfon {0} {1} znajduje sie na {2} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][2],
                                        table.Rows[wiersze_zgodne[j]][3],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][2] + " " + table.Rows[wiersze_zgodne[zaznaczone]][3] +
                                    "\nCPU: " + table.Rows[wiersze_zgodne[zaznaczone]][4] +
                                    "\nGPU: " + table.Rows[wiersze_zgodne[zaznaczone]][5] +
                                    "\nRAM: " + table.Rows[wiersze_zgodne[zaznaczone]][6] +
                                    "\nPrzekatna ekranu: " + table.Rows[wiersze_zgodne[zaznaczone]][7] +
                                    "\nPamiec wbudowana: " + table.Rows[wiersze_zgodne[zaznaczone]][8] +
                                    "\n5G: " + table.Rows[wiersze_zgodne[zaznaczone]][9]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Urządzenie zostało usunięte.\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }

                            string wybor1 = "Table";

                            string id = table.Rows[wiersze_zgodne[zaznaczone]][0].ToString();

                            string marka = table.Rows[wiersze_zgodne[zaznaczone]][2].ToString();

                            string model = table.Rows[wiersze_zgodne[zaznaczone]][3].ToString();
                            usun(wybor1, id, marka, model);
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych smartfonow.\nWciśnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        int zaznaczone = 0;
                        bool done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {

                            if (row[1].ToString() == "Lodowka")
                            {
                                i += 1;
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Lodowka {0} znajduje sie na {1} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][10],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][10] +
                                    "\nKlasa energetyczna: " + table.Rows[wiersze_zgodne[zaznaczone]][11] +
                                    "\nMoc: " + table.Rows[wiersze_zgodne[zaznaczone]][12] +
                                    "\nWaga: " + table.Rows[wiersze_zgodne[zaznaczone]][13] +
                                    "\nPoziom halasu: " + table.Rows[wiersze_zgodne[zaznaczone]][14] +
                                    "\nRoczne zuzycie pradu: " + table.Rows[wiersze_zgodne[zaznaczone]][15]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Urządzenie zostało usunięte.\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                            string wybor1 = "Table";
                            string id = table.Rows[wiersze_zgodne[zaznaczone]][0].ToString();
                            string marka = table.Rows[wiersze_zgodne[zaznaczone]][10].ToString();
                            usun(wybor1, id, marka);
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych lodowek.\nWciśnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        int zaznaczone = 0;
                        bool done = false;
                        List<int> wiersze_zgodne = new List<int>();
                        foreach (DataRow row in table.Rows)
                        {

                            if (row[1].ToString() == "Odkurzacz")
                            {
                                i += 1;
                                wiersze_zgodne.Add(int.Parse(row[0].ToString()) - 1);
                            }
                        }
                        if (i > 0)
                        {
                            while (!done)
                            {
                                for (int j = 0; j < wiersze_zgodne.Count; j++)
                                {
                                    if (zaznaczone == j) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                                    Console.WriteLine("Odkurzacz {0} znajduje sie na {1} pozycji.",
                                        table.Rows[wiersze_zgodne[j]][10],
                                        table.Rows[wiersze_zgodne[j]][0]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\n" +
                                    table.Rows[wiersze_zgodne[zaznaczone]][10] +
                                    "\nKlasa energetyczna: " + table.Rows[wiersze_zgodne[zaznaczone]][11] +
                                    "\nMoc: " + table.Rows[wiersze_zgodne[zaznaczone]][12] +
                                    "\nWaga: " + table.Rows[wiersze_zgodne[zaznaczone]][13] +
                                    "\nPojemnosc: " + table.Rows[wiersze_zgodne[zaznaczone]][16] +
                                    "\nZasieg: " + table.Rows[wiersze_zgodne[zaznaczone]][17]);
                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        zaznaczone = Math.Max(0, zaznaczone - 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        zaznaczone = Math.Min(wiersze_zgodne.Count - 1, zaznaczone + 1);
                                        break;
                                    case ConsoleKey.Enter:
                                        done = true;
                                        break;
                                }
                                if (!done)
                                    Console.CursorTop = Console.CursorTop - wiersze_zgodne.Count;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Urządzenie zostało usunięte.\nWciśnij dowolny przycisk...");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                            string wybor1 = "Table";
                            string id = table.Rows[wiersze_zgodne[zaznaczone]][0].ToString();
                            string marka = table.Rows[wiersze_zgodne[zaznaczone]][10].ToString();
                            usun(wybor1, id, marka);
                        }
                        else
                        {
                            Console.WriteLine("Niestety w bazie nie ma zadnych odkurzaczy.\nWciśnij dowolny przycisk...");
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        drop_db();
                        break;
                    }
                default: { break; }
            }
        }

        public void zapisz_plik()
        {
            DataTable table_it = DataS.Tables["Table"];
            DataS.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "baza.xml");
        }

        private void generator_laptop(int i_marka, int i_model, int i_cpu, int i_gpu, int i_ram, int i_przekatna, int i_pojemnosc)
        {
            string[] marka = { "Asus", "Dell", "MSI", "" },
                model = { "Gaming I", "Office I", "Business I", "" },
                cpu = { "Intel Core i5-11600", "Intel Core i7-11700K", "AMD Ryzen 5 3600", "" },
                gpu = { "Intel UHD 670", "Intel UHD 750", "Nvidia RTX3070Ti", "AMD RX 6600XT", "Nvidia Geforce 820M", "" };
            int[] pojemnosc = { 500, 1000, 2000, 0 };

            dodaj_laptop(0, "Laptop", marka[i_marka], model[i_model], cpu[i_cpu], gpu[i_gpu], i_ram, i_przekatna, pojemnosc[i_pojemnosc]);
        }

        private void generator_smartfon(int i_marka, int i_model, int i_cpu, int i_gpu, int i_ram, int i_przekatna, int i_pojemnosc, int i_5g)
        {
            bool[] _5g = { true, false, true };
            string[] marka = { "Samsung", "Xiaomi", "Huawei", "" },
                model = { "Gaming II", "Office II", "Business II", "" },
                cpu = { "Snapdragon 730", "Exynos 9611", "MediaTek Helio G80", "" },
                gpu = { "A15 Bionic", "Snapdragon 888+", "Exynos 2100", "" };
            int[] pojemnosc = { 32, 128, 256, 0 };

            dodaj_smartfon(0, "Smartfon", marka[i_marka], model[i_model], cpu[i_cpu], gpu[i_gpu], i_ram, i_przekatna, pojemnosc[i_pojemnosc], _5g[i_5g]);
        }

        private void generator_lodowka(int i_producent, int i_klasa, int i_moc, int i_waga, int i_halas, int i_prad)
        {
            string[] producent = { "Samsung", "Whirpool", "Beko", "Amica", "Bosch", "" };
            char[] klasa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'E' };
            dodaj_lodowka(0, "Lodowka", producent[i_producent], klasa[i_klasa], i_moc, i_waga, i_halas, i_prad);
        }

        private void generator_odkurzacz(int i_producent, int i_klasa, int i_moc, int i_waga, int i_pojemnosc, int i_zasieg)
        {
            string[] producent = { "Samsung", "Whirpool", "Beko", "Amica", "Bosch", "" };
            char[] klasa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'E' };
            dodaj_odkurzacz(0, "Odkurzacz", producent[i_producent], klasa[i_klasa], i_moc, i_waga, i_pojemnosc, i_zasieg);
        }

        private void random_gen()
        {
            Random r = new Random();
            int random_typ = r.Next(0, 4);
            int random_marka_laptop = r.Next(0, 3);
            int random_marka_smartfon = r.Next(0, 3);
            int random_prod_agd = r.Next(0, 5);
            int random_model_laptop = r.Next(0, 3);
            int random_model_smartfon = r.Next(0, 3);
            int random_cpu_laptop = r.Next(0, 4);
            int random_cpu_smartfon = r.Next(0, 3);
            int random_gpu_laptop = r.Next(0, 5);
            int random_gpu_smartfon = r.Next(0, 3);
            int random_ram = r.Next(4, 17);
            int random_przekatna_laptop = r.Next(13, 18);
            int random_przekatna_smartfon = r.Next(5, 8);
            int random_pojemnosc_laptop = r.Next(0, 3);
            int random_pojemnosc_smartfon = r.Next(0, 3);
            int random_5g = r.Next(0, 2);
            int random_klasa = r.Next(0, 7);
            int random_moc = r.Next(300, 750);
            int random_waga_lodowka = r.Next(12, 20);
            int random_waga_odkurzacz = r.Next(2, 5);
            int random_halas = r.Next(15, 30);
            int random_pojemnosc = r.Next(2, 8);
            int random_prad = r.Next(1, 10);
            int random_zasieg = r.Next(4, 20);
            switch (random_typ)
            {
                case 0:
                    {
                        generator_laptop(random_marka_laptop, random_model_laptop, random_cpu_laptop, random_gpu_laptop, random_ram, random_przekatna_laptop, random_pojemnosc_laptop);
                        break;
                    }
                case 1:
                    {
                        generator_smartfon(random_marka_smartfon, random_model_smartfon, random_cpu_smartfon, random_gpu_smartfon, random_ram, random_przekatna_smartfon, random_pojemnosc_smartfon, random_5g);
                        break;
                    }
                case 2:
                    {
                        generator_lodowka(random_prod_agd, random_klasa, random_moc, random_waga_lodowka, random_halas, random_prad);
                        break;
                    }
                case 3:
                    {
                        generator_odkurzacz(random_prod_agd, random_klasa, random_moc, random_waga_odkurzacz, random_pojemnosc, random_zasieg);
                        break;
                    }
            }
        }

        private void zapisz_backup()
        {
            DataTable table_it_backup = DataS.Tables["Table"];
            DataS.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "baza_backup.xml");
        }

        public void wczytaj_plik()
        {
            if (File.Exists("baza.xml"))
            {
                FileInfo FileProps = new FileInfo("baza.xml");
                FileInfo FileProps1 = new FileInfo("baza_backup.xml");
                DataS.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "baza.xml");
                DataTable table_it = DataS.Tables["Table"];
                if (table_it.Rows.Count == 0 && File.Exists("baza_backup.xml"))
                {
                    Console.WriteLine("Wyglada na to ze wczytana baza danych jest pusta.\nCzy chcesz wczytać backup ostatniej wypelnionej bazy? [T/N]");
                    Console.WriteLine("\n\nRozmiar oryginalnej bazy w Bajtach: {0}\nRozmiar kopii zapasowej w Bajtach: {1}", FileProps.Length, FileProps1.Length);
                    string wybor;
                    if (FileProps.Length == FileProps1.Length) wybor = "n";
                    else wybor = Console.ReadLine();
                    if (wybor == "T" || wybor == "t")
                    {
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + "baza.xml");
                        DataS.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "baza_backup.xml");
                    }
                    else
                    {
                        Console.WriteLine("Czy chcesz wygenerowac losowa baze danych? [T/N]");
                        wybor = Console.ReadLine();
                        if (wybor == "T" || wybor == "t")
                        {
                            Console.WriteLine("Ile przedmiotow ma byc wygenerowanych?\nW przypadku gdy nie zostanie podana żadna liczba, program wygeneruje 20 przedmiotów");
                            var input = Console.ReadLine();
                            int ilosc;
                            if (Regex.IsMatch(input, @"^\d+$") == true)
                            {
                                ilosc = int.Parse(input);
                                if (ilosc > 150) { ilosc = 150; Console.WriteLine("Żądasz zbyt wiele...\n\nZostanie wygenerowane 150 przedmiotów.\nWciśnij dowolny przycisk..."); Console.ReadKey(); }
                            }
                            else
                                ilosc = 20;
                            for (int i = 0; i < ilosc; i++)
                            {
                                random_gen();
                            }
                        }
                        else
                            DataS.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "baza.xml");
                    }
                }
            }
            else if (File.Exists("baza_backup.xml"))
            {
                string wybor;
                Console.WriteLine("Czy chcesz wygenerowac losowa baze danych? [T/N]");
                wybor = Console.ReadLine();
                if (wybor == "T" || wybor == "t")
                {
                    Console.WriteLine("Ile przedmiotow ma byc wygenerowanych?\nW przypadku gdy nie zostanie podana żadna liczba, program wygeneruje 20 przedmiotów");
                    var input = Console.ReadLine();
                    int ilosc;
                    if (Regex.IsMatch(input, @"^\d+$") == true)
                    {
                        ilosc = int.Parse(input);
                        if (ilosc > 150) { ilosc = 150; Console.WriteLine("Żądasz zbyt wiele...\n\nZostanie wygenerowane 150 przedmiotów.\nWciśnij dowolny przycisk..."); Console.ReadKey();  }
                    }
                    else
                        ilosc=20;
                    for (int i = 0; i < ilosc; i++)
                    {
                        random_gen();
                    }
                }
                else
                    DataS.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "baza_backup.xml");
            }
            else
            {
                string wybor;
                Console.WriteLine("Czy chcesz wygenerowac losowa baze danych? [T/N]");
                wybor = Console.ReadLine();
                if (wybor == "T" || wybor == "t")
                {
                    Console.WriteLine("Ile przedmiotow ma byc wygenerowanych?\nW przypadku gdy nie zostanie podana żadna liczba, program wygeneruje 20 przedmiotów");
                    var input = Console.ReadLine();
                    int ilosc;
                    if (Regex.IsMatch(input, @"^\d+$") == true)
                    {
                        ilosc = int.Parse(input);
                        if (ilosc > 150) { ilosc = 150; Console.WriteLine("Żądasz zbyt wiele...\n\nZostanie wygenerowane 150 przedmiotów.\nWciśnij dowolny przycisk..."); Console.ReadKey(); }
                    }
                    else
                        ilosc = 20;
                    for (int i = 0; i < ilosc; i++)
                    {
                        random_gen();
                    }
                }
            }
        }
    }
}