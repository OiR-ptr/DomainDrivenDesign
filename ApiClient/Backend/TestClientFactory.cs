using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Backend
{
    public class TestClientFactory
    {
        protected readonly HttpClient _httpClient;

        public TestClientFactory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IWeatherForecastClient CreateWeatherForecast()
        {
            return new WeatherForecastClient();
        }
    }
}
