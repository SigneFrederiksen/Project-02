using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_02
{
    public class Customer
    {

        // This is the fields of what the Customer class contains. 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Zipcode { get; set; }
        //public string Country { get; set; }
        public string Password { get; set; }


        // Here we initialize the fields with the correct values.
        public Customer(string firstname, string lastname, int age, int zip, string pass) // string country,
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Zipcode = zip;
            //this.Country = country;
            this.Password = pass;
        }


        // Then we make a ToString method that we will use in .aspx file,
        // that will return a string of each customers. 
        public override string ToString()
        {
            return "Firstname: " + Firstname + ", Lastname: " + Lastname + ", Age: " + Age + ", Zipcode: " + Zipcode + ", Password: " + Password; // ", Country: " + Country + 
        }

    }
}