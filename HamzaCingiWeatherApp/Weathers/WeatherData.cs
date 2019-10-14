using HamzaCingiWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamzaCingiWeatherApp.Weathers
{
    public class WeatherData
    {
        public static List<Weather> WeatherList = new List<Weather>()
        {

            new Weather
            {
                Id =1,
                City = "Istanbul",
                Celcius = 25,
                Status = "Sunny",
                Humidity = 40                 
            },
            new Weather
            {
                Id=2,
                City = "Ankara",
                Celcius= 20,
                Status = "Cloudy",
                Humidity = 35
            },
            new Weather
            {
                Id=3,
                City = "Izmir",
                Celcius= 24,
                Status = "Rainy",
                Humidity = 6
            }
        };
    }
}