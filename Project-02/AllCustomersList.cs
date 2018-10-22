using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_02
{
    public class AllCustomersList
    {
        // Makes a list from the Customer class and calls it ListAll,
        // that holds the data for a Customer.
        private List<Customer> ListAll;

        // Makes a Cunstructor from the class AllCustomersList.
        // Our AllCustomersList with a list of Customer.
        public AllCustomersList()
        {
            ListAll = new List<Customer>();
        }

        // Makes a method that adds our Customers to the ListAll.
        // This is a method, based on the Customer class.
        // It adds the customers to our new CustomerList,
        // and will be called/used when a new Customer is created.
        public void AddCustomer(Customer c)

        {
            ListAll.Add(c);
        }

        // Returns the content of the ListAll. 
        public List<Customer> WhatIsInside()
        {
            return ListAll;
        }
    }
}