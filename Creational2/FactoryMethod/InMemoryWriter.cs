using System.Text;
using FactoryMethod;

public class InMemoryWriter : IWriter
{
    private StringBuilder _builder;
    public InMemoryWriter(StringBuilder sb)
    {
        _builder = sb;
    }
    public void Write(string data)
    {
        _builder.Append(data);
    }
}