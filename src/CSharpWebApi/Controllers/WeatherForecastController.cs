using System;
using System.Collections.Generic;
using System.Web.Http;
using CSharpWebApi.Models;

namespace CSharpWebApi.Controllers
{
    [RoutePrefix("api/weatherforecast")]
    public sealed class WeatherForecastController : ApiController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [Route("")]
        public IEnumerable<WeatherForecast> Get()
        {
            var results = new List<WeatherForecast>();
            for (var index = 1; index <= 5; index++)
            {
                results.Add(new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = new Random().Next(-20, 55),
                    Summary = Summaries[new Random().Next(Summaries.Length)]
                });
            }
            return results;
        }
    }
}
