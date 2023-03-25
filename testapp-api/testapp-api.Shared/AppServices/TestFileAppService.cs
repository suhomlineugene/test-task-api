using System.Globalization;
using System.Reflection;
using System.Text;
using AutoMapper;
using CsvHelper;
using CsvHelper.Configuration;
using testapp_api.Shared.AppServices.Interfaces;
using testapp_api.Shared.Models;

namespace testapp_api.Shared.AppServices;

public class TestFileAppService : ITestFileAppService
{
    private readonly IMapper _mapper;

    public TestFileAppService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<ICollection<TestFileDto>> GetTestFileContent()
    {
        var filePath = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location) ?? string.Empty,
            "data_test.csv");
        using var reader = new StreamReader(filePath, Encoding.UTF8);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };
        using var csv = new CsvReader(reader, config);
        csv.Context.RegisterClassMap<TestFileMap>();

        var records = csv.GetRecords<TestFile>();
        return _mapper.Map<ICollection<TestFileDto>>(records);
    }
}