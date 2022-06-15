namespace Services;


public class MyWriter : IMyWriter
{

    public void Write(string msg)
    {
        Console.WriteLine(msg);

    }

}