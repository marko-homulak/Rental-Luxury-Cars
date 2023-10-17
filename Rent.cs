using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Luxury_Cars
{
    public class Rent
    {
        private string Id { get; set; }
        public string carRegistrationNumber { get; set; }
        public string tenantPhoneNumber { get; set; }
        public string rentDate { get; set; }
        public string returnDate { get; set; }
        public string finalPrice { get; set; }

        public BindingList<Rent> rentalsList = new BindingList<Rent>();

        public string endpoint = "api/v1/rents";

        public Rent()
        {
            rentalsList = new BindingList<Rent>();
        }

        public Rent(string carRegistrationNumber, string tenantPhoneNumber, string rentDate, string returnDate)
        {
            this.carRegistrationNumber = carRegistrationNumber;
            this.tenantPhoneNumber = tenantPhoneNumber;
            this.rentDate = rentDate;
            this.returnDate = returnDate;
        }

        public CollectionJsonItem ToCollectionJsonItem()
        {
            return new CollectionJsonItem
            {
                Href = $"/api/v1/rents/{Id}",
                Data = new List<CollectionJsonItemData>
            {
                new CollectionJsonItemData { Name = "id", Value = Id },
                new CollectionJsonItemData { Name = "carRegistrationNumber", Value = carRegistrationNumber },
                new CollectionJsonItemData { Name = "tenantPhoneNumber", Value = tenantPhoneNumber },
                new CollectionJsonItemData { Name = "rentDate", Value = rentDate },
                new CollectionJsonItemData { Name = "returnDate", Value = returnDate },
                new CollectionJsonItemData { Name = "finalPrice", Value = finalPrice }
            }
            };
        }

        private void FromCollectionJsonToRentalsList(string collection)
        {
            rentalsList.Clear();
            rentalsList = JsonConvert.DeserializeObject<BindingList<Rent>>(collection);
        }

        private void FromCollectionJsonToRent(string collection)
        {
            rentalsList.Add(JsonConvert.DeserializeObject<Rent>(collection));
        }

        public async Task LoadJsonRentals()
        {
            var restClient = new RestClient();
            var rentals = await restClient.GetJsonStringAsync(endpoint);
            FromCollectionJsonToRentalsList(rentals);
        }

        public bool isPhoneUpperUnique(string phone)
        {
            foreach (Rent rent in rentalsList)
            {
                if (String.Equals(phone.ToUpper(), rent.tenantPhoneNumber.ToUpper()))
                {
                    return false;
                }
            }
            return true;
        }

        public async Task addRental(string carRegistrationNumber, string tenantPhoneNumber, string rentDate, string returnDate)
        {
            Rent rent = new Rent(carRegistrationNumber, tenantPhoneNumber, rentDate, returnDate);
            var restClient = new RestClient();
            var id = await restClient.PostAsync(rent.endpoint, rent);
            if (id != null)
            {
                string resultId = id.Substring(1, id.Length - 2);
                MessageBox.Show($"Car rented successfully, id: {resultId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonRentals();          
            }
            else
            {
                MessageBox.Show("Error renting car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task deleteRental(string rentIdentifier)
        {
            var restClient = new RestClient();
            var isDeleted = await restClient.DeleteAsync(endpoint + "/" + rentIdentifier);
            if (isDeleted)
            {
                MessageBox.Show("Rental deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonRentals();
            }
            else
            {
                MessageBox.Show("Error deleting rental", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool isRented(string carRegistrationNumber)
        {
            DateTime todayDate = DateTime.Now;
            DateTime returnDate;
            string dateString = "";
            string format = "yyyy-MM-dd'T'HH:mm:ss";

            foreach (Rent rent in rentalsList)
            {
                if (String.Equals(carRegistrationNumber.ToUpper(), rent.carRegistrationNumber.ToUpper()))
                {
                    dateString = rent.rentDate;
                    if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out returnDate))
                    {
                        if (todayDate <= returnDate)
                        {
                            return false;
                        }
                    }                   
                }
            }
            return true;
        }

    }
}
