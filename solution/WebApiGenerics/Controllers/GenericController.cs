using Microsoft.AspNetCore.Mvc;
using WebApiGenerics.Services;

namespace WebApiGenerics.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class GenericController<T> : ControllerBase where T : class 
{
    private readonly IGenericService<T> _service;

    protected GenericController(IGenericService<T> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.Get());
    }
}