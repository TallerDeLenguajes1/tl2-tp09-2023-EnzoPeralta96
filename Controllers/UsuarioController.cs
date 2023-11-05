using Microsoft.AspNetCore.Mvc;
using RepositorioUsuario;
using Models;

namespace tl2_tp09_2023_EnzoPeralta96.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly UsuarioRepository _usuarioRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        _usuarioRepository = new UsuarioRepository();
    }

    [HttpPost("/api/usuario")]
    public ActionResult<Tarea> CrearUsuario(Usuario usuario)
    {
        _usuarioRepository.CreateUsuario(usuario);
        return Ok(usuario);
    }
}
