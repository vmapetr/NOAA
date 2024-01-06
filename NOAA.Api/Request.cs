using NOAA.Models;
using System.Text.Json;

namespace NOAA.Api
{
    public class Request
    {
        static readonly Uri baseUri = new("https://services.swpc.noaa.gov/json/");
        static readonly HttpClient client = new HttpClient();

        public static async Task<IEnumerable<T>> GetModelAsync<T>() where T : INOAAModel, new()
        {
            T modelInstance = new();

            string response = await client.GetStringAsync(new Uri(baseUri, modelInstance.GetModelUri()));

            IEnumerable<T>? model = JsonSerializer.Deserialize<IEnumerable<T>>(response);

            if (model == null || model.Count() == 0)
            {
                throw new Exception("Empty model");
            }

            return model;
        }

        public static async Task<OvationAuroraLatest> GetOvationAuroraLatestModel()
        {
            OvationAuroraLatest? model = new();

            string response = await client.GetStringAsync(new Uri(baseUri, model.GetModelUri()));

            model = JsonSerializer.Deserialize<OvationAuroraLatest>(response);

            if (model == null)
            {
                throw new Exception("Empty model");
            }

            return model;
        }
    }
}
