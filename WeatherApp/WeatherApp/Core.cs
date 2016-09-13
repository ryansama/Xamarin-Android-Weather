using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string key = "034fd0df882be8061c5b9fcd36d0f214";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="
                + zipCode + ",us&appid=" + key + "&units=metric";

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather
                {
                    Title = (string) results["name"],
                    Temperature = (string) results["main"]["temp"] + " C",
                    Wind = (string) results["wind"]["speed"] + " mph",
                    Humidity = (string) results["main"]["humidity"] + " %",
                    Visibility = (string) results["weather"][0]["main"]
                };

                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise + " UTC";
                weather.Sunset = sunset + " UTC";
                return weather;
            }

            return null;
        }
    }
}
