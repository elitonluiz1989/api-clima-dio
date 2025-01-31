using ApiClimaDio;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.MapOpenApi();

app.UseHttpsRedirection();

WeatherForecastEndpoints.AddWeatherForecastEndpoint(app);

app.Run();