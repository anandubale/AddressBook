using System;
using System.Collections.Generic;
namespace AddressBookTrail
{   

    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Address Book.");
            Console.WriteLine("nChoose the operation:\n1.Add Contact.\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Exit Adress Book Application.\n6.Check Duplicate \n7.SearchPerson\n8.Check Person Using City\n9.Find Number Of Person");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        addressBook.StoreContact();
                        break;
                    case "2":
                        addressBook.DisplayAllContact();
                        break;
                    case "3":
                        addressBook.EditContact();
                        break;
                    case "4":
                        addressBook.DeleteContact();
                        break;
                    case "5":
                        return;
                    case "6":
                        addressBook.DuplicateChecker();
                        break;
                    case "7":
                        addressBook.SearchPerson();
                        break;
                    case "8":
                        addressBook.FindCityState();
                        break;
                    case "9":
                        addressBook.FindNumOfPerson();
                        break;
                    default:
                        Console.WriteLine("! Choose valid operation ");
                        break;
                }
                Console.WriteLine("nChoose the operation:\n1.Add Another Contact.\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Exit Adress Book Application.\n6.Check Duplicate \n7.SearchPerson\n8.Check Person Using City\n9.Find Number Of Person");
                userInput = Console.ReadLine();
            }
        }
    }
}
