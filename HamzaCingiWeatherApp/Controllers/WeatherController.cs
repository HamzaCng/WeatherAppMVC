using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HamzaCingiWeatherApp.Models;
using HamzaCingiWeatherApp.Weathers;


namespace HamzaCingiWeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            return View(WeatherData.WeatherList);
        }

        // GET: Weather/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Weather/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: JsonResult/Data
        public ActionResult GetJson()
        {
            return View();
        }
        public ActionResult JsonData()
        {
            return Json(WeatherData.WeatherList, JsonRequestBehavior.AllowGet);
        }

        // GET: Selected Weather        
        public ActionResult SelectedWeather()
        {
            SelectList selectListWeather = new SelectList(WeatherData.WeatherList,"Celcius","City");
            ViewBag.data = selectListWeather;

            return View();
        }
        [HttpPost]
        public ActionResult SelectedWeather(int SelectedWeather)        {          

             
            ViewBag.SelectedWeather = new SelectList(WeatherData.WeatherList, "Celcius", "City");
            ViewBag.SelectedWeather = SelectedWeather;

            return View();
        }



        // POST: Weather/Create
        [Route("Weather/addWeathers")]
        [HttpPost]        
        public ActionResult Create(Weather yeniWeather)
        {
            try
            {
                Weather addWeather = new Weather()
                {
                   City = yeniWeather.City,
                   Celcius = yeniWeather.Celcius,
                   Status = yeniWeather.Status,
                   Humidity = yeniWeather.Humidity
                };

                WeatherData.WeatherList.Add(addWeather);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Weather/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Weather/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Weather/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Weather/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
