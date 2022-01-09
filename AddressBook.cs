using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System
{
    class AddressBook
    {
        private static List<PersonsDetails> contacts = new List<PersonsDetails>();

        private static Dictionary<string, List<PersonsDetails>> addressBook = new Dictionary<string, List<PersonsDetails>>();

        public static void AddTo(string name)
        {
            addressBook.Add(name, contacts);
        }
        public static void AddContact()
        {
            PersonsDetails person = new PersonsDetails();

            Console.Write(" Enter your First name : ");
            person.FirstName = Console.ReadLine();
            Console.Write(" Enter your Last name : ");
            person.LastName = Console.ReadLine();
            Console.Write(" Enter your Address : ");
            person.Address = Console.ReadLine();
            Console.Write(" Enter your City : ");
            person.City = Console.ReadLine();
            Console.Write(" Enter your State : ");
            person.State = Console.ReadLine();
            Console.Write(" Enter your Zip Code : ");
            person.ZipCode = Console.ReadLine();
            Console.Write(" Enter your Phone Number : ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write(" Enter your Email-ID : ");
            person.Email = Console.ReadLine();

            contacts.Add(person);
            Console.WriteLine("\n {0}'s contact succesfully added", person.FirstName);
        }

        public static void Details()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Currently there are no people added in your address book.");
            }
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                foreach (var Detailing in contacts)
                {
                    Console.WriteLine("First name : " + Detailing.FirstName);
                    Console.WriteLine("Last name : " + Detailing.LastName);
                    Console.WriteLine("Address : " + Detailing.Address);
                    Console.WriteLine("State : " + Detailing.State);
                    Console.WriteLine("City : " + Detailing.City);
                    Console.WriteLine("Zip Code : " + Detailing.ZipCode);
                    Console.WriteLine("Phone number = " + Detailing.PhoneNumber);
                }
            }
        }

        public static int SearchDuplicate(List<PersonsDetails> contacts, PersonsDetails contactBook)
        {
            foreach (var Details in contacts)
            {
                var person = contacts.Find(p => p.FirstName.Equals(contactBook.FirstName));
                if (person != null)
                {
                    Console.WriteLine("Already this contact exist with same First name : " + person.FirstName);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}