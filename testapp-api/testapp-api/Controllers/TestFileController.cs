using Microsoft.AspNetCore.Mvc;
using testapp_api.Shared.AppServices.Interfaces;
using testapp_api.Shared.Models;

namespace testapp_api.Controllers;

[Route("api/[controller]/[action]")]
public class TestFileController : Controller
{
    private readonly ITestFileAppService _testFileAppService;

    public TestFileController(ITestFileAppService testFileAppService)
    {
        _testFileAppService = testFileAppService;
    }

    [HttpGet]
    public async Task<IEnumerable<TestFileDto>> GetFileData()
    {
        var fileData = await _testFileAppService.GetTestFileContent();

        return fileData;
    }
}