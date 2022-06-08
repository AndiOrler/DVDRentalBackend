using Xunit;
using Services;


namespace UnitTests;

public class MyServiceTest
{
    [Fact]
    public void GetStringTest()
    {
        var ser = new MyService();

        string result = ser.GetString();

        Assert.Equal(result, "hello world");

    }
}