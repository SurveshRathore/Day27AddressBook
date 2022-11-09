using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27AddressBook
{
    internal class UC2AddContact
    {
        
        public void addContact()
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



            //UC2AddContact addContact = new(fName, lName, city, state, zip, number, email);
            //addContact.personDetails();
            UC1Contact contact = new(fName,lName, address, city, state, zip, number, email);

            Console.WriteLine("Name: {0} {1} Address: {2} City: {3} State: {4} Zip: {5} Phone Number: {6} Email: {7}", contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.PhoneNumber, contact.Zip, contact.Email);

        }
    }
}
