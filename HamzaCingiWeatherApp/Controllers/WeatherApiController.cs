using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HamzaCingiWeatherApp.Models;
using HamzaCingiWeatherApp.Weathers;

namespace HamzaCingiWeatherApp.Controllers
{
    public class WeatherApiController : ApiController
    {
        // GET: api/WeatherApi
        public IEnumerable<Weather> Get()
        {
            return WeatherData.WeatherList;
        }

        // GET: api/WeatherApi/5
        public IHttpActionResult Get(int id)
        {
            var searchWeather = (WeatherData.WeatherList.Where(w => w.Id == id)).FirstOrDefault();
            if (searchWeather==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(searchWeather);
            }
            
        }

        // POST: api/WeatherApi
        [HttpPost]
        public IHttpActionResult Post([FromBody]Weather yeniWeather)
        {
            var City = yeniWeather != null ? yeniWeather.City : "";            
            var Celcius = yeniWeather?.Celcius ?? null; //sıcaklık 0 olabileceği için.
            var Status = yeniWeather != null ? yeniWeather.Status : "";
            var Humdidity = yeniWeather?.Humidity ?? null;

            WeatherData.WeatherList.Add(yeniWeather);
            return Ok(yeniWeather.City);

        }

        // PUT: api/WeatherApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WeatherApi/5
        public void Delete(int id)
        {
        }
    }


}
