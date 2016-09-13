﻿namespace WeatherApp
{
    public class Weather
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Weather()
        {
            Title = " ";
            Temperature = " ";
            Wind = " ";
            Humidity = " ";
            Visibility = " ";
            Sunrise = " ";
            Sunset = " ";
        }
    }
}
