using NewsAppProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAppProject.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=2b40790cc1b98b86d142162d2c58019e&lang=en&topic="+categoryName.ToLower());
            // deserialization
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
