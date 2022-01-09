using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC6
            Console.Write("Enter Number of Address Book you want : ");
            int numBook = Convert.ToInt32(Console.ReadLine());
            int numberBook = 0;
            int key = 1;
            while (numberBook < numBook)
            {
                Console.Write("\n Enter name of Address Book : ");
                string book = Console.ReadLine();
                Console.WriteLine("\n Select the below option");
                Console.WriteLine("1.Add Contact Details \n2.View Contact Details \n3.Edit Contact Details \n4.Delete Contact Details");
                Console.Write("Enter Your Choice : ");
                int num = Convert.ToInt32(Console.ReadLine());

                while (key != 0)
                {
                    switch (num)
                    {

                        case 1:
                            MultipleAddressBook.AddContact();
                            break;
                        case 2:
                            MultipleAddressBook.Details();
                            break;
                        default:
                            Console.Write("Choice correct option : ");
                            num = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    Console.Write("\n Do you wish to continue, press 1 or If you don't want then press any key : ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if (key == 1)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                MultipleAddressBook.AddTo(book);
                numberBook++;
            }
        }
    }
}

