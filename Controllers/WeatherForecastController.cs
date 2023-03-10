using Microsoft.AspNetCore.Mvc;
using Weather_Forecast_Example_With_EFCore.Repository;

namespace Weather_Forecast_Example_With_EFCore.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{	
		private readonly ILogger<WeatherForecastController> _logger;
		private readonly IWeatherForecastRepo _weatherForecastRepo;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastRepo weatherForecastRepo)
		{
			_logger = logger;
			_weatherForecastRepo = weatherForecastRepo;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return _weatherForecastRepo.Get();
			
		}
	}
}