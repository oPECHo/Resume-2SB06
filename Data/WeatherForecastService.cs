namespace Resume.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecast[] WeatherForecasts { get; set; }
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            if (WeatherForecasts is null)
            {
                WeatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = startDate.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                }).ToArray();
            }
            return Task.FromResult(WeatherForecasts);
        }
    }

}
