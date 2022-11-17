using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            #region KanyeVsRon
            //var client = new HttpClient();
            //var quote = new RonVSKanyeAPI(client);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("------------------------");
            //    Console.WriteLine($"Kanye: {quote.KanyeWest()}");

            //    Console.WriteLine();

            //    Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
            //}
            #endregion

            #region OpenWeatherMap
            var client = new HttpClient();
            int n, i;
            Console.WriteLine("Please enter your API Key: ");
            string? v1 = Console.ReadLine();
            var key = v1;


            string v = $"{key}";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?id=4726206&appid={v1}&units=imperial";
            //var weatherURL = $"http://api.openweathermap.org/data/2.5/forecast?id=4726206&appid={v1}&units=imperial";

            var response = client.GetStringAsync(weatherURL).Result;
            

            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
            Console.WriteLine();
            Console.WriteLine($"The current Temperature is {JObject.Parse(formattedResponse).GetValue("temp")} degrees Fahrenheit");

            //JObject formattedResponse = JObject.Parse(response);
            //var temp = formattedResponse["list"][0]["main"]["temp"];
            //Console.WriteLine(temp);
            #endregion
        }
    }
} 