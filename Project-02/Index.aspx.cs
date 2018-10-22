using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_02
{
    public partial class Index : System.Web.UI.Page
    {

        private AllCustomersList thelist;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["SharedCustomerList"] == null)
            {
                Application["SharedCustomerList"] = new AllCustomersList();
            }

            thelist = (AllCustomersList)Application["SharedCustomerList"];
            //UpdateCustomerList();

        }



        // When the button is clicked a new Customer will be created.
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            // Creates a new object which is our new Customer.
            Customer c = new Customer(TextBoxFirstname.Text, TextBoxLastname.Text, Int32.Parse(TextBoxAge.Text), Int32.Parse(TextBoxZipcode.Text), TextBoxRegion.Text, TextBoxPassword.Text);

            thelist = (AllCustomersList)Application["SharedCustomerList"];
            // Calls the AddCustomer method.
            thelist.AddCustomer(c);
            Application["SharedCustomerList"] = thelist;
            Application.UnLock();

            // Calls the method UpdateCustomerList.
            UpdateCustomerList();
        }



        // This method will update the ListBoxCustomer,
        // and will be called/used when a new Customer is created. 
        private void UpdateCustomerList()
        {
            // Clears/removes all items from the list
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInList = thelist.WhatIsInside();
            foreach (Customer c in CustomersInList)
            {
                ListBoxCustomers.Items.Add(c.ToString());
            }
        }



        // Button view all Customers.
        protected void ButtonAllCustomers_Click(object sender, EventArgs e)
        {
            UpdateCustomerList();
        }



        // Button view Customers from Zealand.
        protected void ButtonZealand_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInList = thelist.WhatIsInside();
            foreach (Customer c in CustomersInList)
            {
                if (c.Region == "Zealand")
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
            }
        }



        // Button view Customers from Jutland
        protected void ButtonJutland_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInList = thelist.WhatIsInside();
            foreach (Customer c in CustomersInList)
            {
                if (c.Region == "Jutland")
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
            }
        }



        // Button view Customers from Funen
        protected void ButtonFunen_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            List<Customer> CustomersInList = thelist.WhatIsInside();
            foreach (Customer c in CustomersInList)
            {
                if (c.Region == "Funen")
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
            }
        }













        // Makes a new list out of the Customer class and, 
        // calls it CustomerList.
        //private static List<Customer> CustomerList = new List<Customer>();


        // This is a method, based on the Customer class.
        // It adds the customers to our new CustomerList,
        // and will be called/used when a new Customer is created.
        /*public void AddCustomer(Customer c)
        {
            CustomerList.Add(c);
        }*/






    }
}