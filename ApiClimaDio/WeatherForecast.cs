public sealed record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    public int TemperatureK => 273 + (int)(TemperatureC / 0.5556);
}