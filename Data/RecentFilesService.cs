using System.Text.Json;

namespace InsuranceAnalyzer.Data;

public class RecentFilesService
{
    private const int MaximumFileCount = 10;
    private readonly string _settingsPath;

    public RecentFilesService()
    {
        var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "InsuranceAnalyzer");
        Directory.CreateDirectory(folder);
        _settingsPath = Path.Combine(folder, "recent-files.json");
    }

    public List<string> Load()
    {
        if (!File.Exists(_settingsPath))
            return new List<string>();

        var json = File.ReadAllText(_settingsPath);
        var files = JsonSerializer.Deserialize<List<string>>(json);
        if (files == null)
            files = new List<string>();

        return files.Where(File.Exists).Take(MaximumFileCount).ToList();
    }

    public void Add(string path, List<string> files)
    {
        for (var index = files.Count - 1; index >= 0; index--)
        {
            if (string.Equals(files[index], path, StringComparison.OrdinalIgnoreCase))
                files.RemoveAt(index);
        }

        files.Insert(0, path);
        if (files.Count > MaximumFileCount)
            files.RemoveRange(MaximumFileCount, files.Count - MaximumFileCount);
        File.WriteAllText(_settingsPath, JsonSerializer.Serialize(files));
    }
}
