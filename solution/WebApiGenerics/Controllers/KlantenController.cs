using Microsoft.AspNetCore.Mvc;
using WebApiGenerics.Model;
using WebApiGenerics.Services;

namespace WebApiGenerics.Controllers;

[ApiController]
[Route("[controller]")]
public class KlantenController : ControllerBase
{
    private readonly IGenericService<Klant> _klantenService;

    public KlantenController(IGenericService<Klant> klantenService)
    {
        _klantenService = klantenService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _klantenService.Get());
    }
}