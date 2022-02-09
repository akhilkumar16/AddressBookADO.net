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
        }
    }
}
