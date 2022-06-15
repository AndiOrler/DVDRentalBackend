using Models;

namespace Services;
public class MyService
{
    public IEnumerable<WeatherForecast> GetString(String[] strings)
    {
        return Enumerable.Range(1, strings.Length).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = strings[Random.Shared.Next(strings.Length)]
        })
        .ToArray();
    }

}