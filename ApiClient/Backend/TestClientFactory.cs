using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Backend
{
    public class TestClientFactory
    {
        public async Task<int> Test()
        {
            var client = new WeatherForecastClient();
            var weather = await client.GetAsync();
            return weather.Count;
        }
    }
}
