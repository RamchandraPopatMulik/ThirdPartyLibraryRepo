using CsvHelper;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyLibraray
{
    public class CsvDataHandling
    {
        private TextReader reader;
        private TextWriter writer;

        public void ImplementCvsDataHandling()
        {
            string importfilepath = @"E:\Basic Core Program\ThirdPartyLibraray\ThirdPartyLibraray\Address.csv";
            string exportfilepath = @"E:\Basic Core Program\ThirdPartyLibraray\ThirdPartyLibraray\Export.csv";

            using (var reader = new StreamReader(importfilepath)) ;
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read Data Successfully From Address.csv File");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.Firstname);
                    Console.Write("\t" + addressData.Lastname);
                    Console.Write("\t" + addressData.Address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.ZipCode);
                    Console.Write("\n");
                }
                Console.WriteLine("Now Reading From Csv File Write to Csv ");
                using (var writer = new StreamWriter(exportfilepath)) ;
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
