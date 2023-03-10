using Microsoft.EntityFrameworkCore;

namespace Weather_Forecast_Example_With_EFCore.Contexts
{
	public class WeatherForecastDataContext : DbContext
	{
        public WeatherForecastDataContext(DbContextOptions<WeatherForecastDataContext> dbContextOptions)
        {
            
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=DIPLLPTP0389\\SQLEXPRESS2019;Database=TestDB_ForAPIPractice;Trusted_Connection=true;TrustServerCertificate=true;User ID=sa;Password=p@ssw0rd19");
		}

		public DbSet<WeatherForecast> WeatherForecasts { get; set; }
	}
}
