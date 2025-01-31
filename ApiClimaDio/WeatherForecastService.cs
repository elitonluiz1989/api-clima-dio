namespace ApiClimaDio;

public static class WeatherForecastService
{
    private static string[] _summaries = [
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool", "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    ];

    public static WeatherForecast[] GetWeatherForecast()
    {
        WeatherForecast[] forecast = Enumerable
            .Range(1, 5)
            .Select(index =>
                new WeatherForecast (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    _summaries[Random.Shared.Next(_summaries.Length)]
                )
            )
            .ToArray();

        return forecast;
    }
}