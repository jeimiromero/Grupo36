using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public List<Ganadero> Ganaderos { get; set; }
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ganadero> Get()
        {
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();

            var ganadero = new Ganadero
            {
                Nombres = "Mario",
                Apellidos = "Herrera",
                NumeroTelefono = "3148596563",
                Direccion = "Kra 4 #45-12",
                Correo = "sergio.mintic@ucaldas.edu.co",
                Contrasena = "123456",
                Latitude = 7455,
                Longitud = 5333
            };

            Ganaderos = new List<Ganadero>();
            Ganaderos.Add(ganadero);

            return Ganaderos;
        }
    }
}
