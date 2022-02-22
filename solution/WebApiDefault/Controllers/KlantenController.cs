using Microsoft.AspNetCore.Mvc;
using WebApiDefault.Services;

namespace WebApiDefault.Controllers;

[ApiController]
[Route("[controller]")]
public class KlantenController : ControllerBase
{
    private readonly IKlantenService _klantenService;

    public KlantenController(IKlantenService klantenService)
    {
        _klantenService = klantenService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _klantenService.Get());
    }
}