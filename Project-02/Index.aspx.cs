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
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateCustomerList();
        }

        // Makes a new list out of the Customer class and, 
        // calls it CustomerList.
        private static List<Customer> CustomerList = new List<Customer>();


        // This is a method, based on the Customer class.
        // It adds the customers to our new CustomerList,
        // and will be called/used when a new Customer is created.
        public void AddCustomer(Customer c)
        {
            CustomerList.Add(c);
        }


        // This method will update the ListBoxCustomer,
        // and will be called/used when a new Customer is created. 
        private void UpdateCustomerList()
        {
            // Clears/removes all items from the list
            ListBoxCustomers.Items.Clear();

            foreach (Customer NewCustomer in CustomerList)
            {
                ListBoxCustomers.Items.Add(NewCustomer.ToString());
            }
        }


        // When the button is clicked a new Customer will be created.
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            // Creates a new object which is our new Customer.
            Customer NewCustomer = new Customer(TextBoxFirstname.Text, TextBoxLastname.Text, Int32.Parse(TextBoxAge.Text), Int32.Parse(TextBoxZipcode.Text), TextBoxPassword.Text); // TextBoxCountry.Text,

            // Calls the AddCustomer method.
            AddCustomer(NewCustomer);

            // Calls the method UpdateCustomerList.
            UpdateCustomerList();
        }


    }
}