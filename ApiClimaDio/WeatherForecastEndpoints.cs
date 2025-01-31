namespace ApiClimaDio;

public static class WeatherForecastEndpoints
{
    public static void AddWeatherForecastEndpoint(WebApplication app)
    {
        app.MapGet("/weatherforecast", WeatherForecastService.GetWeatherForecast).WithName("GetWeatherForecast");
    }
}