namespace Weather_Forecast_Example_With_EFCore.Repository
{
	public interface IWeatherForecastRepo
	{
		public IEnumerable<WeatherForecast> Get();
	}
}
