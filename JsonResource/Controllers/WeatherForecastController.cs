using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonResource.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IStringLocalizer<WeatherForecastController> _localizer;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStringLocalizer<WeatherForecastController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        // http://localhost:PORT/weatherforecast
        // http://localhost:PORT/weatherforecast?culture=en-GB
        // http://localhost:PORT/weatherforecast?culture=de-DE
        [HttpGet]
        public string Get()
        {
            return _localizer["SayHello"];

        }

        // http://localhost:PORT/weatherforecast/hamed
        // http://localhost:PORT/weatherforecast/hamed?culture=en-GB
        // http://localhost:PORT/weatherforecast/hamed?culture=de-DE
        [HttpGet("{name}")]
        public string Get(string name)
        {

            return _localizer[string.Format(_localizer["GreetingMessage"], name)];

        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok();
            }
        }
    }
}
