using System.Text;
using FactoryMethod;

public class InMemoryReportMaker : SpendingsReportMaker
{
    private StringBuilder _output; 
    public InMemoryReportMaker(StringBuilder sb)
    {
        _output = sb;
    }
    protected override IWriter CreateWriter()
    {
        return new InMemoryWriter(_output);
    }
}