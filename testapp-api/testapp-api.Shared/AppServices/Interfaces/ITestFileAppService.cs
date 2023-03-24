using testapp_api.Shared.Models;

namespace testapp_api.Shared.AppServices.Interfaces;

public interface ITestFileAppService
{
    Task<ICollection<TestFileDto>> GetTestFileContent();
}