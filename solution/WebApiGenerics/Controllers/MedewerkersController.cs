using Microsoft.AspNetCore.Mvc;
using WebApiDefault.Services;

namespace WebApiDefault.Controllers;

[ApiController]
[Route("[controller]")]
public class MedewerkersController : ControllerBase
{
    private readonly IMedewerkersService _medewerkersService;

    public MedewerkersController(IMedewerkersService medewerkersService)
    {
        _medewerkersService = medewerkersService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _medewerkersService.Get());
    }
}