using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace AddressBookTrail
{
    class FileIO
    {
        public static void WriteDataToTxt(Dictionary<string, Contact> DictName)
        {
            const string PATH = @"C:\Users\anand\Desktop\Bridgelabz\Day10Assigment\AddressBook\AddressBookTrail\AddressBookTrail\TextFile1.txt";
            if (File.Exists(PATH))
            {
                using (TextWriter tw = new StreamWriter(PATH))
                {
                    tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,Email"));
                    foreach (var element in DictName)
                    {
                        tw.WriteLine(string.Format($"{element.Value.FirstName},{element.Value.LastName},{element.Value.Address},{element.Value.City},{element.Value.State},{element.Value.ZipCode},{element.Value.PhoneNumber},{element.Value.Email}"));
                    }
                }
            }
            else Console.WriteLine("File doesn't exist, Check the Path");
        }
        public static void WriteDataToCSV(Dictionary<string, Contact> DictName)
        {
            const string CSVPATH = @"C:\Users\anand\Desktop\Bridgelabz\Day10Assigment\AddressBook\AddressBookTrail\AddressBookTrail\StoredContact.csv";
            if (File.Exists(CSVPATH))
            {
                using (TextWriter tw = new StreamWriter(CSVPATH))
                {
                    tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,Email"));
                    foreach (var element in DictName)
                    {
                        tw.WriteLine(string.Format($"{element.Value.FirstName},{element.Value.LastName},{element.Value.Address},{element.Value.City},{element.Value.State},{element.Value.ZipCode},{element.Value.PhoneNumber},{element.Value.Email}"));
                    }
                }
            }
            else Console.WriteLine("File doesn't exist, Check the Path");
        }
    }
}
