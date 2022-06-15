using Xunit;
using System;
using Services;
using Models;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        var ser = new MyService();

        var strings = new String[] {"hello", "bello"};
        var result = ser.GetString(strings);

        foreach (WeatherForecast wet in result)
        {
            Console.WriteLine(wet.Summary);

        }
        var x = true;
        Assert.True(x);

    }
}