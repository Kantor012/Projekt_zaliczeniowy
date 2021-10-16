namespace Projekt_zaliczeniowy.Class
{
    public class AGD : Urzadzenia
    {
        public int ilosc_agd { get; set; }
        protected char klasa_energetyczna { get; set; }
        protected int waga { get; set; }
        protected int moc { get; set; }
        protected string producent { get; set; }
        public AGD()
        {
            System.Console.WriteLine("Jestem AGD");
        }

        
    }
}
