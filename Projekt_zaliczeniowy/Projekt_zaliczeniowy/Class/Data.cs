using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace Projekt_zaliczeniowy.Class
{
    public class Data
    {
        public static System.Data.DataSet DataS;
        DataSet IOfile = new DataSet();
        DataTable IOfileTable = new DataTable();
        public void DataCreate()
        {
            Urzadzenia();
            DataIT();
            DataAGD();
            //DataRelation();
        }
        
        public void Urzadzenia()
        {
            DataTable table1 = new DataTable("Urzadzenia");
            DataColumn column;
            //DataRow row;

            //Utworzenie kolumny o nazwie "id" w głównej tabeli
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            table1.Columns.Add(column);

            //Utworzenie kolumny o nazwie "Typ" w głównej tabeli
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Typ";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table1.Columns["id"];
            table1.PrimaryKey = PrimaryKeyColumns;

            DataS = new DataSet();
            DataS.Tables.Add(table1);
            
        }

        public void DataIT()
        {
            DataTable table = new DataTable("IT_Table");
            DataColumn column;
            //DataRow row;

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "IT_ID";
            column.AutoIncrement = true;
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;

            // Add the column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Rodzaj";
            column.AutoIncrement = false;
            column.Caption = "Rodzaj";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Marka";
            column.AutoIncrement = false;
            column.Caption = "Marka";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Model";
            column.AutoIncrement = false;
            column.Caption = "Model";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CPU";
            column.AutoIncrement = false;
            column.Caption = "CPU";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "GPU";
            column.AutoIncrement = false;
            column.Caption = "GPU";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "RAM";
            column.AutoIncrement = false;
            column.Caption = "RAM [GB]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Przekatna";
            column.AutoIncrement = false;
            column.Caption = "Przekatna ekranu \"";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Pojemnosc";
            column.AutoIncrement = false;
            column.Caption = "Pojemnosc [GB]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Boolean");
            column.ColumnName = "5G";
            column.AutoIncrement = false;
            column.Caption = "5G";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            DataS.Tables.Add(table);
            Console.WriteLine(table.Columns.Count);            
        }

        public void DataAGD()
        {
            DataTable table = new DataTable("AGD_Table");
            DataColumn column;
            //DataRow row;

            // Create first column and add to the DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AGD_ID";
            column.AutoIncrement = true;
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;

            // Add the column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Rodzaj";
            column.AutoIncrement = false;
            column.Caption = "Rodzaj";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Producent";
            column.AutoIncrement = false;
            column.Caption = "Producent";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Char");
            column.ColumnName = "Klasa_ene";
            column.AutoIncrement = false;
            column.Caption = "Klasa energetyczna";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Moc";
            column.AutoIncrement = false;
            column.Caption = "Moc [W]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Waga";
            column.AutoIncrement = false;
            column.Caption = "Waga [kg]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Halas";
            column.AutoIncrement = false;
            column.Caption = "Poziom halasu [dB]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Prad";
            column.AutoIncrement = false;
            column.Caption = "Roczne zuz. pradu [kWh]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Pojemnosc";
            column.AutoIncrement = false;
            column.Caption = "Pojemnosc pojemnika/worka [L]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Zasieg";
            column.AutoIncrement = false;
            column.Caption = "Zasieg pracy [m]";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            DataS.Tables.Add(table);
            Console.WriteLine(table.Columns.Count);
        }


        /*public void DataRelation()
        {
            DataColumn parentColumn =
                DataS.Tables["Urzadzenia"].Columns["id"];
            DataColumn childColumn =
                DataS.Tables["IT_Table"].Columns[0];
            DataRelation relation = new
                DataRelation("Urzadzenia_to_IT", parentColumn, childColumn);
            DataS.Tables["IT_Table"].ParentRelations.Add(relation);
            
            childColumn = DataS.Tables["AGD_Table"].Columns[0];
            relation = new DataRelation("Urzadzenia_to_AGD", parentColumn, childColumn);
            DataS.Tables["AGD_Table"].ParentRelations.Add(relation);
        }*/

        private void BindToDataGrid()
        {
            
            //SetDataBinding(DataS, "Urzadzenia");
        }


        public static void dodaj_laptop(int id, string rodz, string marka, string model, string cpu, string gpu, int ram, int przekatna, int pojemnosc)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "IT";
            //table = new DataTable();
            DataTable table = DataS.Tables["IT_Table"];
            DataTable table1 = DataS.Tables["AGD_Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row[0] = table.Rows.Count + table1.Rows.Count + 1;
            row["Rodzaj"] = rodz;
            row["Marka"] = marka;
            row["Model"] = model;
            row["CPU"] = cpu;
            row["GPU"] = gpu;
            row["RAM"] = ram;
            row["Przekatna"] = przekatna;
            row["Pojemnosc"] = pojemnosc;
            //row["5G"] = "";
            table.Rows.Add(row);
            table.AcceptChanges();
        }

        public static void dodaj_smartfon(int id, string rodz, string marka, string model, string cpu, string gpu, int ram, int przekatna, int pojemnosc, bool _5G)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "IT";
            // table = new DataTable();
            DataTable table = DataS.Tables["IT_Table"];
            DataTable table1 = DataS.Tables["AGD_Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row[0] = table.Rows.Count + table1.Rows.Count + 1;
            row["Rodzaj"] = rodz;
            row["Marka"] = marka;
            row["Model"] = model;
            row["CPU"] = cpu;
            row["GPU"] = gpu;
            row["RAM"] = ram;
            row["Przekatna"] = przekatna;
            row["Pojemnosc"] = pojemnosc;
            row["5G"] = _5G;
            table.Rows.Add(row);
            table.AcceptChanges();
        }

        public static void dodaj_lodowka(int id, string rodz, string producent, char klasa, int moc, int waga, int halas, int prad)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "AGD";
            //DataTable table = new DataTable();
            DataTable table = DataS.Tables["AGD_Table"];
            DataTable table1 = DataS.Tables["IT_Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row[0] = table.Rows.Count + table1.Rows.Count + 1;
            row["Rodzaj"] = rodz;
            row["Producent"] = producent;
            row["Klasa_ene"] = klasa;
            row["Moc"] = moc;
            row["Waga"] = waga;
            row[6] = halas;
            row[7] = prad;
            //row["Pojemnosc"] = "";
            //row["Zasieg"] = "";
            table.Rows.Add(row);
            table.AcceptChanges();
        }

        public static void dodaj_odkurzacz(int id, string rodz, string producent, char klasa, int moc, int waga, int pojemnosc, int zasieg)
        {
            DataTable urzadzenie = DataS.Tables["Urzadzenia"];
            DataRow U_row = urzadzenie.NewRow();
            U_row["id"] = urzadzenie.Rows.Count + 1;
            U_row["Typ"] = "AGD";
            //DataTable table = new DataTable();
            DataTable table = DataS.Tables["AGD_Table"];
            DataTable table1 = DataS.Tables["IT_Table"];
            DataRow row = table.NewRow();
            Console.WriteLine(table.Columns.Count);
            row[0] = id;
            row["Rodzaj"] = rodz;
            row["Producent"] = producent;
            row["Klasa_ene"] = klasa;
            row["Moc"] = moc;
            row["Waga"] = waga;
            //row["Halas"] = "";
            //row["Prad"] = "";
            row[6] = pojemnosc;
            row[7] = zasieg;
            table.Rows.Add(row);
            table.AcceptChanges();
        }

        public void wyswietl()
        {
            DataTable table = DataS.Tables["IT_Table"];
            DataTable table1 = DataS.Tables["AGD_Table"];
           // table.Merge(table1);
            
            foreach (DataRow row in table.Rows)
            {           
                    string id = row[0].ToString();
                    string rodzaj = row[1].ToString();
                    string marka = row[2].ToString();
                    string model = row[3].ToString();
                    string cpu = row[4].ToString();
                    string gpu = row[5].ToString();
                    string ram = row[6].ToString();
                    string przekatna = row[7].ToString();
                    string pojemnosc = row[8].ToString();
                    Console.WriteLine("\n\n" + id + ", " + rodzaj + ", " + marka + ", " + model);
                    Console.WriteLine("cpu: {0}\ngpu: {1}\nram: {2}\nprzekatna: {3}\npojemnosc w GB: {4}", cpu, gpu, ram, przekatna, pojemnosc);
                    if (rodzaj == "Smartfon")
                    {
                        string _5G = row[9].ToString();
                        Console.WriteLine("5G: {0}", _5G);
                    }
            }
            
            foreach (DataRow row in table1.Rows)
            {
                string id = row[0].ToString();
                string rodzaj = row[1].ToString();
                string producent = row[2].ToString();
                string klasa_ene = row[3].ToString();
                string moc = row[4].ToString();
                string waga = row[5].ToString();
                string halas_pojemnosc = row[6].ToString();
                string prad_zasieg = row[7].ToString();
                Console.WriteLine("\n\n" + id + ", " + rodzaj + ", " + producent);
                if (rodzaj == "Lodowka") 
                {                    
                    Console.WriteLine("Klasa energetyczna: {0}\nMoc [W]: {1}\nWaga [kg]: {2}\nHalas [dB]: {3}\nZuzycie pradu w ciagu roku [kWh]: {4}", klasa_ene, moc, waga, halas_pojemnosc, prad_zasieg);
                }
                else if (rodzaj == "Odkurzacz")
                {
                    Console.WriteLine("Klasa energetyczna: {0}\nMoc [W]: {1}\nWaga [kg]: {2}\nPojemnosc pojemnika/worka [L]: {3}\nZasieg pracy [m]: {4}", klasa_ene, moc, waga, halas_pojemnosc, prad_zasieg);
                };
            }
        }
        public void znajdz()
        {
            DataTable table = DataS.Tables["IT_Table"];
            DataTable table1 = DataS.Tables["AGD_Table"];
            Console.WriteLine("Co chcesz wyswietlic?\n1. Laptop\n2. Smarfton\n3. Lodowka\n4. Odkurzacz");
            int wybor=Convert.ToInt32(Console.ReadLine());
            int wybor_nr;
            switch (wybor)
            {
                case 1: 
                    foreach (DataRow row in table.Rows) 
                    {
                        if (row[1].ToString() == "Laptop") { Console.WriteLine("Laptop {0} {1} znajduje się na {2} pozycji.", row[2].ToString(), row[3].ToString(), row[0].ToString()); }
                    } 
                    Console.WriteLine("Ktora pozycje mam wyswietlic?");
                    wybor_nr = Convert.ToInt32(Console.ReadLine());
                    foreach (DataRow row in table.Rows)
                    {
                        if (wybor_nr == Convert.ToInt32(row[0])) 
                        {
                            string id = row[0].ToString();
                            string rodzaj = row[1].ToString();
                            string marka = row[2].ToString();
                            string model = row[3].ToString();
                            string cpu = row[4].ToString();
                            string gpu = row[5].ToString();
                            string ram = row[6].ToString();
                            string przekatna = row[7].ToString();
                            string pojemnosc = row[8].ToString();
                            Console.WriteLine("\n\n" + id + ", " + rodzaj + ", " + marka + ", " + model);
                            Console.WriteLine("cpu: {0}\ngpu: {1}\nram: {2}\nprzekatna: {3}\npojemnosc w GB: {4}", cpu, gpu, ram, przekatna, pojemnosc);
                            Console.ReadLine();
                        }
                    }
                    break;
                case 2:  break;
                case 3:break;
                case 4:break;
                default: Console.WriteLine("Wpisano zly numer, wprowadz numer ponownie"); break;
            }
            
        }
        public void zapisz_plik()
        {
            DataTable table_it = DataS.Tables["IT_Table"];
            DataTable table_agd = DataS.Tables["AGD_Tables"];
            //DataS.Tables.Add(table_it);
            //DataS.Tables.Add(table_agd);
            DataS.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "baza.xml");
        }

        public void wczytaj_plik()
        {
            DataS.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "baza.xml");
        }
    }
    
}