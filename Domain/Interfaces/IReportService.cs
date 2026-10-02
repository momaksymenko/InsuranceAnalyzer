using InsuranceAnalyzer.Domain.Entities;

namespace InsuranceAnalyzer.Domain.Interfaces;

public interface IReportService
{
    void Create(string path, List<InsuranceRecord> records, List<string> chartPaths);
}
