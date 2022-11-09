using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27AddressBook
{
    public class UC1Contact
    {
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private int zip;
        private int phoneNumber;
        private String email;
        public UC1Contact(String fName, String lName, String add, String city, String state, int zip, int number, String mail)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.address = add;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = number;
            this.email = mail;
            
        }
        public String FirstName { get { return firstName; } set { firstName = value; } }
        public String LastName { get { return lastName; } set { lastName = value; } }
        public String Address { get { return address; } set { address = value; } }
        public String City { get { return city; } set { city = value; } }
        public String State { get { return state; } set { state = value; } }
        public int Zip { get { return zip; } set { zip = value; } }
        public int PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
