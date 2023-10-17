using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Rental_Luxury_Cars
{
    public class RestClient
    {
        private readonly HttpClient httpClient;
        private const string baseUrl = "http://localhost:8080/";

        public RestClient()
        {
            httpClient = new HttpClient();
        }

        public async Task<BindingList<T>> GetItemsAsync<T>(string endpoint)
        {
            var fullUrl = baseUrl + endpoint;
            var response = await httpClient.GetFromJsonAsync<BindingList<T>>(fullUrl);
            return response ?? new BindingList<T>();
        }

        public async Task<CollectionJson> GetCollectionJsonAsync(string endpoint)
        {
            var fullUrl = baseUrl + endpoint;
            var response = await httpClient.GetFromJsonAsync<CollectionJson>(fullUrl);
            return response ?? new CollectionJson();
        }

        public async Task<string> GetJsonStringAsync(string endpoint)
        {
            var fullUrl = baseUrl + endpoint;
            var response = await httpClient.GetAsync(fullUrl);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PostAsync<T>(string endpoint, T item)
        {
            var fullUrl = baseUrl + endpoint;
            var itemJson = JsonConvert.SerializeObject(item);

            var content = new StringContent(itemJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(fullUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                var errorMessage = "Server returned error: " + response.StatusCode;

                if (response.Content != null)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    errorMessage += Environment.NewLine + errorContent;
                }

                Console.WriteLine(errorMessage);
                return null;
            }
        }

        public async Task<string> PostAsync(string endpoint, string parameterString)
        {
            var fullUrl = baseUrl + endpoint;
            var content = new StringContent(parameterString, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(fullUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                var errorMessage = "Server returned error: " + response.StatusCode;

                if (response.Content != null)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    errorMessage += Environment.NewLine + errorContent;
                }

                Console.WriteLine(errorMessage);
                return null;
            }
        }

        public async Task<bool> DeleteAsync(string endpoint)
        {
            var fullUrl = baseUrl + endpoint;

            var response = await httpClient.DeleteAsync(fullUrl);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                var errorMessage = "Server returned error: " + response.StatusCode;

                if (response.Content != null)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    errorMessage += Environment.NewLine + errorContent;
                }

                Console.WriteLine(errorMessage);
                return false;
            }
        }

        public async Task<bool> PutAsync<T>(string endpoint, T item)
        {
            var fullUrl = baseUrl + endpoint;
            var itemJson = JsonConvert.SerializeObject(item);

            var content = new StringContent(itemJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(fullUrl, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                var errorMessage = "Server returned error: " + response.StatusCode;

                if (response.Content != null)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    errorMessage += Environment.NewLine + errorContent;
                }

                Console.WriteLine(errorMessage);
                return false;
            }
        }

    }

    public class CollectionJsonItemData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CollectionJsonItem
    {
        public string Href { get; set; }
        public IList<CollectionJsonItemData> Data { get; set; }
    }

    public class CollectionJsonTemplateData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CollectionJsonTemplate
    {
        public IList<CollectionJsonTemplateData> Data { get; set; }
    }

    public class CollectionJson
    {
        public string Version { get; set; }
        public CollectionJsonItem Collection { get; set; }
    }
}
