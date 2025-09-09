namespace StatePattern;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var outputStream = new MemoryStream();
        var connection = new NetworkConnection(outputStream);

        connection.Open();
        connection.Send("Hello!");
        connection.Close();

        outputStream.Seek(0, SeekOrigin.Begin);
        var textReader = new StreamReader(outputStream);
        var output = textReader.ReadToEnd();
        
        Assert.Equal("Connection opened.\nHello! transmitted.\nClosing connection.\n", output);
    }
}