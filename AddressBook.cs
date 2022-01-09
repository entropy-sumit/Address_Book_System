using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AddressBookSystem
{
    class AddressBook
    {
        private static List<PersonsDetails> contacts = new List<PersonsDetails>();

        private static Dictionary<string, List<PersonsDetails>> addressBook = new Dictionary<string, List<PersonsDetails>>();

        public static Dictionary<string, List<PersonsDetails>> cityBook = new Dictionary<string, List<PersonsDetails>>();
        public static Dictionary<string, List<PersonsDetails>> stateBook = new Dictionary<string, List<PersonsDetails>>();

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

        public static void SearchCity()
        {
            Console.WriteLine("Please Enter Name of city");
            string city = Console.ReadLine();
            foreach (var Details in contacts)
            {
                var person = contacts.Find(p => p.City.Equals(city));
                if (person != null)
                {
                    Console.WriteLine("{0} person in the {1}", Details.FirstName, city);
                }
                else
                {

                }
            }

        }

        //This method for search person using state name
        public static void SearchState()
        {
            Console.WriteLine("Please Enter Name of State");
            string state = Console.ReadLine();
            foreach (var Details in contacts)
            {
                var person = contacts.Find(p => p.State.Equals(state));
                if (person != null)
                {
                    Console.WriteLine("{0} person in the {1}", Details.FirstName, state);
                }
                else
                {

                }
            }

        }
        //This method for add person details by using city name
        public void AddByCity()
        {
            foreach (var Detail in contacts)
            {
                string city = Detail.City;
                if (cityBook.ContainsKey(city))
                {
                    List<PersonsDetails> exist = cityBook[city];
                    exist.Add(Detail);
                }
                else
                {
                    List<PersonsDetails> cityContact = new List<PersonsDetails>();
                    cityContact.Add(Detail);
                    cityBook.Add(city, cityContact);
                }
            }
        }
        //This method for add person details by using  state name
        public void AddByState()
        {
            foreach (var Detail in contacts)
            {
                string state = Detail.State;
                if (stateBook.ContainsKey(state))
                {
                    List<PersonsDetails> exists = stateBook[state];
                    exists.Add(Detail);

                }
                else
                {
                    List<PersonsDetails> stateContact = new List<PersonsDetails>();
                    stateContact.Add(Detail);
                    stateBook.Add(state, stateContact);
                }
            }
        }

        public static void CountByCityOrStateName()
        {
            Console.WriteLine("Select 1 : count person by city, \n2: Count person by state");
            int num = Convert.ToInt32(Console.ReadLine());
            void CountByCity()
            {
                foreach (var item in cityBook)
                {
                    int count = item.Value.Count();
                    Console.WriteLine("There are {0} number of people in City- {1}", count, item.Key);
                }
            }
            void CountBystate()
            {
                foreach (var item in stateBook)
                {
                    int count = item.Value.Count();
                    Console.WriteLine("There are {0} number of people in City- {1}", count, item.Key);
                }
            }

            if (num == 1)
            {
                //When there are atleast 1 entry
                if (cityBook.Count != 0)
                {
                    CountByCity();
                }
                else
                {
                    Console.WriteLine("Currently no entries stored");
                }
            }
            else if (num == 2)
            {
                if (stateBook.Count != 0)
                {
                    CountBystate();
                }
                else
                {
                    Console.WriteLine("Currently no entries stored");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please select between 1 and 2");
            }
        }
    }
}