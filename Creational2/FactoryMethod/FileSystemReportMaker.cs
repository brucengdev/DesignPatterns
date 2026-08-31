namespace FactoryMethod;
using System.Text;

public class FileSystemReportMaker : SpendingsReportMaker
{
    private string _reportFileName;
    public FileSystemReportMaker(string reportFileName)
    {
        _reportFileName = reportFileName;
    }
    protected override IWriter CreateWriter()
    {
        return new ReportFileWriter(_reportFileName);
    }
}