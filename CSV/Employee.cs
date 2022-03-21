using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class Employee
    {


            public string firstName, lastName, address, city, country, state;  
            public string zip, phone1, phone;
            public string email;
            public Employee()
            {

            }
            public Employee(string firstName, string lastName,  string address, string city, string country, string state, string zip, string phone1, string phone, string email)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                
                this.address = address;
                this.city = city;
                this.country = country;
                this.state = state;
                this.zip = zip;
                this.phone1 = phone1;
                this.phone = phone;
                this.email = email;
            }

            public string getInfo()
            {
                return this.firstName + "\t" + this.lastName + "\t" + this.email;
            }

            public string getDetailedInformation()
            {
                return "Name: " + this.firstName + " " + this.lastName + "\t" + "Address: " + this.address + ", " + this.city + ", " + this.country + ", " + this.state+ "\t" + "Phone Number: " + this.phone + "\t" + "Email: " + this.email;
            }
        
    }
}
