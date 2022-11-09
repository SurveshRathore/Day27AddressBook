using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27AddressBook
{
    internal class UC3EditContact
    {
        public void editContact()
        {
            Console.Write("Enter the person First Name: ");
            String fName = Console.ReadLine();
            Console.Write("Enter the person last Name: ");
            String lName = Console.ReadLine();
            Console.Write("Enter the person address: ");
            String address = Console.ReadLine();
            Console.Write("Enter the person city: ");
            String city = Console.ReadLine();
            Console.Write("Enter the person state: ");
            String state = Console.ReadLine();
            Console.Write("Enter the person zip: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the person phone number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the person email: ");
            String email = Console.ReadLine();

            UC1Contact person = new(fName, lName, address, city, state, zip, number, email);

            Console.WriteLine("Name: {0} {1} Address: {2} City: {3} State: {4} Zip: {5} Phone Number: {6} Email: {7}", person.FirstName, person.LastName, person.Address, person.City, person.State, person.Zip, person.PhoneNumber,  person.Email);

            Console.Write("Enter the person name to edit the contact: ");
            fName = Console.ReadLine();
            if (fName == person.FirstName)
            {
                Console.WriteLine("Select the person details to edit");
                Console.WriteLine("1. Edit the Last name");
                Console.WriteLine("2. Edit the Address");
                Console.WriteLine("3. Edit the City");
                Console.WriteLine("4. Edit the State");
                Console.WriteLine("5. Edit the Zip");
                Console.WriteLine("6. Edit the Phone Number");
                Console.WriteLine("7. Edit the Email");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter the person last Name: ");
                        lName = Console.ReadLine();
                        person.LastName =lName;
                        break;
                    case 2:
                        Console.Write("Enter the person address: ");
                        address = Console.ReadLine();
                        person.Address = address;
                        break;
                    case 3:
                        Console.Write("Enter the person city: ");
                        city = Console.ReadLine();
                        person.City = city;
                        break;
                    case 4:
                        Console.Write("Enter the person state: ");
                        state = Console.ReadLine();
                        person.State = state;
                        break;
                    case 5:
                        Console.Write("Enter the person zip: ");
                        zip = Convert.ToInt32(Console.ReadLine());
                        person.Zip = zip;
                        break;
                    case 6:
                        Console.Write("Enter the person phone number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        person.PhoneNumber = number;
                        break;
                    case 7:
                        Console.Write("Enter the person email: ");
                        email = Console.ReadLine();
                        person.Email = email;
                        break;
                    default: Console.WriteLine("Invalid Choice"); break;

                }
            }
            Console.WriteLine("Name: {0} {1} Address: {2} City: {3} State: {4} Zip: {5} Phone Number: {6} Email: {7}", person.FirstName, person.LastName, person.Address, person.City, person.State, person.Zip, person.PhoneNumber,  person.Email);
        }            
    }
}
