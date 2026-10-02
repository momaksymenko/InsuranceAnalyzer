namespace InsuranceAnalyzer.Data.Logging;

public class FileLogger
{
    private readonly string _path;
    public FileLogger(string outputFolder)
    {
        Directory.CreateDirectory(outputFolder);
        _path = Path.Combine(outputFolder, "events.log");
    }

    public void Write(string action, string message)
    {
        File.AppendAllText(_path, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}; {action}; {message}{Environment.NewLine}");
    }
}
