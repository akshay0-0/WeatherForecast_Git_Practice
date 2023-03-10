using System.ComponentModel.DataAnnotations;

namespace Weather_Forecast_Example_With_EFCore
{
	public class WeatherForecast
	{
		[Key]
		[Required]
		public Guid Id { get; set; }
		public DateTime Date { get; set; }

		public int TemperatureC { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; set; }
	}
}