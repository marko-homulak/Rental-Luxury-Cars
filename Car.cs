using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Esf;
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
    public class Car
    {
        private string Id { get; set; }
        public string registrationNumber { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string pricePerDay { get; set; }
        public string carStatus { get; set; }

        public BindingList<Car> carsList = new BindingList<Car>();

        public string endpoint = "api/v1/cars";

        public Car()
        {
            carsList = new BindingList<Car>();
        }

        public Car(string registrationNumber, string brand, string model, string color, string pricePerDay)
        {
            this.registrationNumber = registrationNumber;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.pricePerDay = pricePerDay;
        }

        public CollectionJsonItem ToCollectionJsonItem()
        {
            return new CollectionJsonItem
            {
                Href = $"/api/v1/cars/{Id}",
                Data = new List<CollectionJsonItemData>
            {
                new CollectionJsonItemData { Name = "id", Value = Id },
                new CollectionJsonItemData { Name = "registrationNumber", Value = registrationNumber },
                new CollectionJsonItemData { Name = "brand", Value = brand },
                new CollectionJsonItemData { Name = "model", Value = model },
                new CollectionJsonItemData { Name = "color", Value = color },
                new CollectionJsonItemData { Name = "pricePerDay", Value = pricePerDay },
                new CollectionJsonItemData { Name = "carStatus", Value = carStatus }
            }
            };
        }

        private void FromCollectionJsonToCarsList(string collection)
        {
            carsList.Clear();
            carsList = JsonConvert.DeserializeObject<BindingList<Car>>(collection);
        }

        private void FromCollectionJsonToCar(string collection)
        {
            carsList.Add(JsonConvert.DeserializeObject<Car>(collection));
        }

        public async Task LoadJsonCars()
        {
            var restClient = new RestClient();
            var cars = await restClient.GetJsonStringAsync(endpoint);
            FromCollectionJsonToCarsList(cars);
        }

        public async Task addCar(string registrationNumber, string brand, string model, string color, string pricePerDay)
        {
            Car car = new Car(registrationNumber, brand, model, color, pricePerDay);
            var restClient = new RestClient();
            var id = await restClient.PostAsync(car.endpoint, car);
            if (id != null) 
            {
                string resultId = id.Substring(1, id.Length - 2);               
                MessageBox.Show($"Car added successfully, id: {resultId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCars();
            }
            else
            {
                MessageBox.Show("Error adding car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task deleteCar(string carIdentifier)
        {
            var restClient = new RestClient();
            var isDeleted = await restClient.DeleteAsync(endpoint + "/" + carIdentifier);
            if (isDeleted)
            {              
                MessageBox.Show("Car deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCars();
            }
            else
            {
                MessageBox.Show("Error deleting car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task editCar(string carIdentifier, string brand, string model, string color, string pricePerDay, string carStatus)
        {
            var restClient = new RestClient();
            bool isPutted = false;
            foreach (Car car in carsList)
            {
                if(String.Equals(carIdentifier.ToUpper(), car.registrationNumber.ToUpper()))
                {
                    car.brand = brand;
                    car.model = model;
                    car.color = color;
                    car.pricePerDay = pricePerDay;
                    car.carStatus = carStatus;
                    isPutted = await restClient.PutAsync(endpoint + "/" + carIdentifier, car);
                    break;
                }
            }

            if(isPutted)
            {
                MessageBox.Show("Car edited successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCars();
            }
            else
            {
                MessageBox.Show("Error editing car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task editCar(string carIdentifier, string carStatus)
        {
            var restClient = new RestClient();
            bool isPutted = false;
            foreach (Car car in carsList)
            {
                if (String.Equals(carIdentifier.ToUpper(), car.registrationNumber.ToUpper()))
                {
                    car.carStatus = carStatus;
                    isPutted = await restClient.PutAsync(endpoint + "/" + carIdentifier, car);
                    break;
                }
            }

            if (isPutted)
            {
                MessageBox.Show("Car edited successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadJsonCars();
            }
            else
            {
                MessageBox.Show("Error editing car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void uploadAvailableCars(ComboBox comboBox)
        {
            string status = "AVAILABLE";

            foreach (Car car in carsList)
            {
                if (String.Equals(status.ToUpper(), car.carStatus.ToUpper()))
                {
                    comboBox.Items.Add(car.registrationNumber);
                }
            }
        }

    }
}
