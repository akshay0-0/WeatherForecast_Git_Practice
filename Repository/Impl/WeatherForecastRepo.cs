using Weather_Forecast_Example_With_EFCore.Contexts;

namespace Weather_Forecast_Example_With_EFCore.Repository.Impl
{
	public class WeatherForecastRepo : IWeatherForecastRepo
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};
		private readonly WeatherForecastDataContext _weatherForecastDataContext;

		public WeatherForecastRepo(WeatherForecastDataContext weatherForecastDataContext)
        {
            _weatherForecastDataContext = weatherForecastDataContext;
        }
        public IEnumerable<WeatherForecast> Get()
		{
			return _weatherForecastDataContext.WeatherForecasts.ToArray();
		}
	}
}
