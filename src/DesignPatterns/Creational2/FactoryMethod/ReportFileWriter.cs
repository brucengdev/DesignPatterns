namespace FactoryMethod;

public class ReportFileWriter : IWriter
{
    private string reportFileName;

    public ReportFileWriter(string reportFileName)
    {
        this.reportFileName = reportFileName;
    }

    public void Write(string data)
    {
        File.AppendAllText(reportFileName, data);
    }
}