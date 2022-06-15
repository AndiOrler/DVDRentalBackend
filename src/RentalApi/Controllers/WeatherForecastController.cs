using Microsoft.AspNetCore.Mvc;
using Models;
using Services;


namespace RentalApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IMyWriter _writer;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
    IMyWriter writerService)
    {
        _logger = logger;
        _writer = writerService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("FOOOOOOOOOOOOO");

        _writer.Write("written from writerService");
        
        var ser = new MyService();        

        return ser.GetString(Summaries);
    }
}
