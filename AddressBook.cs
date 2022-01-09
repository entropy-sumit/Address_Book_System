using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        private static List<PersonsDetails> contacts = new List<PersonsDetails>();

        private static Dictionary<string, List<PersonsDetails>> addressBook = new Dictionary<string, List<PersonsDetails>>();

        public IEnumerable<KeyValuePair<string, List<PersonsDetails>>> State { get; private set; }
        public IEnumerable<KeyValuePair<string, List<PersonsDetails>>> City { get; private set; }

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

        public static void ViewByCityOrStateName()
        {
            Console.WriteLine("Please select your option: \n 1 :  To view all contacts by city, \n 2 : To view all contacts by state.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int cityCount = AddressBook.Count();
                if (cityCount != 0)
                {
                    foreach (KeyValuePair<string, List<PersonsDetails>> item in City)
                    {
                        Console.WriteLine("\n Following are the Person details residing in the city -" + item.Key);
                        foreach (var items in item.Value)
                        {
                            //Printing added details
                            Console.WriteLine("First Name : " + items.FirstName);
                            Console.WriteLine("Last Name : " + items.LastName);
                            Console.WriteLine("Address : " + items.Address);
                            Console.WriteLine("Phone Number : " + items.PhoneNumber);
                            Console.WriteLine("Email ID : " + items.Email);
                            Console.WriteLine("City : " + items.City);
                            Console.WriteLine("State : " + items.State);
                            Console.WriteLine("ZIP code : " + items.ZipCode);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\nCurrently no entries are inserted.");
                }
            }
            else if (choice == 2)
            {

                int stateCount = AddressBook.Count();
                if (stateCount != 0)
                {
                    foreach (KeyValuePair<string, List<PersonsDetails>> item in State)
                    {
                        Console.WriteLine("\n Following are the Person details residing in the state -" + item.Key);
                        foreach (var items in item.Value)
                        {
                            //Printing added details
                            Console.WriteLine("First Name : " + items.FirstName);
                            Console.WriteLine("Last Name : " + items.LastName);
                            Console.WriteLine("Address : " + items.Address);
                            Console.WriteLine("Phone Number : " + items.PhoneNumber);
                            Console.WriteLine("Email ID : " + items.Email);
                            Console.WriteLine("City : " + items.City);
                            Console.WriteLine("State : " + items.State);
                            Console.WriteLine("ZIP code : " + items.ZipCode);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\nCurrently no entries are inserted.");
                }

            }
            else
            {
                Console.WriteLine("\nWrong entry, Please choose between 1 and 2");
            }
        }

        private static int Count()
        {
            throw new NotImplementedException();
        }
    }
}