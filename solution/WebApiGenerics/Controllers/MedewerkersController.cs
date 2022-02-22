using Microsoft.AspNetCore.Mvc;
using WebApiGenerics.Model;
using WebApiGenerics.Services;

namespace WebApiGenerics.Controllers;

[ApiController]
[Route("[controller]")]
public class MedewerkersController : ControllerBase
{
    private readonly IGenericService<Medewerker> _medewerkersService;

    public MedewerkersController(IGenericService<Medewerker> medewerkersService)
    {
        _medewerkersService = medewerkersService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _medewerkersService.Get());
    }
}