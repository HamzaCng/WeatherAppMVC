using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamzaCingiWeatherApp.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int Celcius { get; set; }
        public string Status { get; set; }
        public int Humidity { get; set; }

    }
}