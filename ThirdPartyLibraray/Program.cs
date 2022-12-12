namespace ThirdPartyLibraray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Read Data From CSV and Write Data in CSV ");
            CsvDataHandling csvDataHandling = new CsvDataHandling();
            csvDataHandling.ImplementCvsDataHandling();
        }
    }
}