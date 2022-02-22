using Microsoft.AspNetCore.Mvc;
using WebApiGenerics.Services;

namespace WebApiGenerics.Controllers;

[ApiController]
[Route("[controller]")]
public class AutosController : ControllerBase
{
    private readonly IAutosService _autosService;

    public AutosController(IAutosService autosService)
    {
        _autosService = autosService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _autosService.Get());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var auto = await _autosService.Get(id);
        if (auto is null)
        {
            return NotFound();
        }

        return Ok(auto);
    }
}