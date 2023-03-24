using System.Globalization;
using AutoMapper;
using CsvHelper;
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
        using (var reader = new StreamReader("path\\to\\file.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<TestFile>();
            return _mapper.Map<ICollection<TestFileDto>>(records);
        }
    }
}