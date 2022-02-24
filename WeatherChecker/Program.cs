using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            Console.WriteLine("Please give me a city name:");
            var cityName = Console.ReadLine();

            var weatherUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=e6b1ea90b19a1576a1ea6a730d6cb553&units=imperial";

            var response = client.GetStringAsync(weatherUrl).Result;
            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

            Console.WriteLine(formattedResponse);
            

        }
    }
}
