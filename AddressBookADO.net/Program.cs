using System;

namespace AddressBookADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addressbook ADO.net");
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            //UC1
            addressBookManagement.DataBaseConnection();
            //UC2
            addressBookManagement.GetAllContact();
            //UC3
            AddNewContactDetails();
        }

        /* UC3:- Ability to insert new Contacts to Address Book */
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "rohit";
            model.LastName = "sharma";
            model.Address = "hnk";
            model.City = "mumbai";
            model.State = "mh";
            model.Zip = "124562";
            model.PhoneNumber = "123456789";
            model.EmailId = "rohit@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "rohit";
            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }
}
