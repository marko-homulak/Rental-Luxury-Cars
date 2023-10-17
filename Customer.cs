using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Luxury_Cars
{
    public class Customer
    {
        private string Id { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }

        public BindingList<Customer> customersList = new BindingList<Customer>();

        public string endpoint = "api/v1/tenants";

        public Customer()
        {
            customersList = new BindingList<Customer>();
        }

        public Customer(string fullName, string address, string phoneNumber)
        {
            this.fullName = fullName;
            this.address = address;
            this.phoneNumber = phoneNumber; 
        }

        public CollectionJsonItem ToCollectionJsonItem()
        {
            return new CollectionJsonItem
            {
                Href = $"/api/v1/tenants/{Id}",
                Data = new List<CollectionJsonItemData>
            {
                new CollectionJsonItemData { Name = "id", Value = Id },
                new CollectionJsonItemData { Name = "address", Value = address },
                new CollectionJsonItemData { Name = "fullname", Value = fullName },
                new CollectionJsonItemData { Name = "phoneNumber", Value = phoneNumber }
            }
            };
        }

        private void FromCollectionJsonToCustomersList(string collection)
        {
            customersList.Clear();
            customersList = JsonConvert.DeserializeObject<BindingList<Customer>>(collection);
        }

        private void FromCollectionJsonToCustomer(string collection)
        {
            customersList.Add(JsonConvert.DeserializeObject<Customer>(collection));
        }

        public async Task LoadJsonCustomers()
        {
            var restClient = new RestClient();
            var customers = await restClient.GetJsonStringAsync(endpoint);
            FromCollectionJsonToCustomersList(customers);
        }

        public async Task addCustomer(string fullName, string address, string phoneNumber)
        {
            Customer customer = new Customer(fullName, address, phoneNumber);
            var restClient = new RestClient();
            var id = await restClient.PostAsync(customer.endpoint, customer);
            if (id != null)
            {
                string resultId = id.Substring(1, id.Length - 2);
                MessageBox.Show($"Customer added successfully, id: {resultId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCustomers();
            }
            else
            {
                MessageBox.Show("Error adding customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task deleteCustomer(string customerIdentifier)
        {
            var restClient = new RestClient();
            var isDeleted = await restClient.DeleteAsync(endpoint + "/" + customerIdentifier);
            if (isDeleted)
            {
                MessageBox.Show("Customer deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCustomers();
            }
            else
            {
                MessageBox.Show("Error deleting customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task editCustomer(string customerIdentifier, string fullName, string address)
        {
            var restClient = new RestClient();
            bool isPutted = false;
            foreach (Customer customer in customersList)
            {
                if (String.Equals(customerIdentifier.ToUpper(), customer.phoneNumber.ToUpper()))
                {
                    customer.fullName = fullName;
                    customer.address = address;
                    isPutted = await restClient.PutAsync(endpoint + "/" + customerIdentifier, customer);
                    break;
                }
            }

            if (isPutted)
            {
                MessageBox.Show("Customer edited successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCustomers();
            }
            else
            {
                MessageBox.Show("Error editing customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void uploadCustomersPhones(ComboBox comboBox)
        {
            foreach (Customer customer in customersList)
            {
                comboBox.Items.Add(customer.phoneNumber);
            }
        }

        public void getCustomerFullName(string phone, Bunifu.Framework.UI.BunifuMaterialTextbox textBox)
        {
            foreach (Customer customer in customersList)
            {
                if (customer.phoneNumber == phone)
                {
                    textBox.Text = customer.fullName;
                    break;
                }
            }
        }

    }
}
