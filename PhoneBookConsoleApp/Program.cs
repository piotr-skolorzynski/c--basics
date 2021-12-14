using System;

namespace PhoneBookConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from PhoneBook app ;)");
            Console.WriteLine("Possible actions: ");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("5 Remove contact");
            Console.WriteLine("To exit insert 'x'");

            var userInput = Console.ReadLine();

            //create object to be a phone book
            var phoneBook = new PhoneBook();

            while (true) 
            {
                //react on chosen option
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("insert number");
                        var number = Console.ReadLine();
                        if(number.Length < 9)
                        {
                            Console.WriteLine("Phone number should consist of 9 numbers");
                            break;
                        }
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();
                        if(name.Length < 3 )
                        {
                            Console.WriteLine("Contact name should consist of minimum 3 letters");
                            break;
                        }
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("insert number to search");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "5":
                        Console.WriteLine("Insert number to remove");
                        var phoneNumberToRemove = Console.ReadLine();
                        if (phoneNumberToRemove.Length < 9)
                        {
                            Console.WriteLine("Phone number to remove should consist of 9 numbers");
                            break;
                        }
                        phoneBook.RemoveContactByNumber(phoneNumberToRemove);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}
