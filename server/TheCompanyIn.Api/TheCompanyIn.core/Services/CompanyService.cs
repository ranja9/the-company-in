using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TheCompanyIn.Core.Interfaces;
using TheCompanyIn.Core.ViewModels;

namespace TheCompanyIn.Core.Services
{

    public class CompanyService : ICompanyService
    {
        const string basePath = "https://company.clearbit.com/v2";

        public async Task<T> GetCompanyMetadataAsync<T>(string companyDomain)
        {
            string requestPath = $"companies/find?domain={companyDomain}";
            var resJson = await GetAsync(requestPath);
            var res = JsonSerializer.Deserialize<T>(resJson);
            return res;
        }

        public async Task<T> GetCompanyInfoAsync<T>(string id)
        {
            string requestPath = $"companies/{id}";
            var resJson = await GetAsync(requestPath);
            var res = JsonSerializer.Deserialize<T>(resJson);
            return res;
        }

        private async Task<string> GetAsync(string requestPath)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "sk_30240e2d1dfc1d73d26ab80390d1fd49");
                var url = new Uri($"{basePath}/{requestPath}");
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Error Code " + response.StatusCode);
                }
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return json;
            }
        }
    }
}
