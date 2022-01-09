using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to Address Book Program.\n");

            // UC4
            AddressBook.AddContact();
            AddressBook.Display();
            AddressBook.Delete();
            AddressBook.Display();
        }
    }
}
