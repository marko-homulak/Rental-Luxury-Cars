using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Luxury_Cars
{
    public class Return
    {
        private string Id { get; set; }
        public string carRegistrationNumber { get; set; }
        public string tenantPhoneNumber { get; set; }
        public string returnDate { get; set; }
        public string delayInDays { get; set; }
        public string totalPayment { get; set; }

        public BindingList<Return> returnsList = new BindingList<Return>();

        public string endpoint = "api/v1/rent-records";

        public Return()
        {
            returnsList = new BindingList<Return>();
        }

        public Return(string carRegistrationNumber, string tenantPhoneNumber, string returnDate, string delayInDays, string totalPayment)
        {
            this.carRegistrationNumber = carRegistrationNumber;
            this.tenantPhoneNumber = tenantPhoneNumber;
            this.returnDate = returnDate;
            this.delayInDays = delayInDays;
            this.totalPayment = totalPayment;
        }

        public CollectionJsonItem ToCollectionJsonItem()
        {
            return new CollectionJsonItem
            {
                Href = $"/api/v1/rent-records/{Id}",
                Data = new List<CollectionJsonItemData>
            {
                new CollectionJsonItemData { Name = "id", Value = Id },
                new CollectionJsonItemData { Name = "carRegistrationNumber", Value = carRegistrationNumber },
                new CollectionJsonItemData { Name = "tenantPhoneNumber", Value = tenantPhoneNumber },
                new CollectionJsonItemData { Name = "returnDate", Value = returnDate },
                new CollectionJsonItemData { Name = "delayInDays", Value = delayInDays },
                new CollectionJsonItemData { Name = "totalPayment", Value = totalPayment }
            }
            };
        }

        private void FromCollectionJsonToRentalsList(string collection)
        {
            returnsList.Clear();
            returnsList = JsonConvert.DeserializeObject<BindingList<Return>>(collection);
        }

        private void FromCollectionJsonToRent(string collection)
        {
            returnsList.Add(JsonConvert.DeserializeObject<Return>(collection));
        }

        public async Task LoadJsonRentRecords()
        {
            var restClient = new RestClient();
            var rentRecords = await restClient.GetJsonStringAsync(endpoint);
            FromCollectionJsonToRentalsList(rentRecords);
        }

        public async Task addRentRecord(string rentIdentifier, string carStatus)
        {
            string request = "{\"rentIdentifier\": \"" + rentIdentifier + "\", \"returnCarStatus\": \"" + carStatus + "\"}";

            Return ret = new Return();
            var restClient = new RestClient();
            var id = await restClient.PostAsync(ret.endpoint, request);
            if (id != null)
            {
                string resultId = id.Substring(1, id.Length - 2);
                MessageBox.Show($"Car return successfully, id: {resultId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonRentRecords();
            }
            else
            {
                MessageBox.Show("Error returning car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
