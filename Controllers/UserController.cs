using Microsoft.AspNetCore.Mvc;
using RepositorioUsuario;
using Models.Usuario;

namespace tl2_tp09_2023_EnzoPeralta96.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly UsuarioRepository _usuarioRepository;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
        _usuarioRepository = new UsuarioRepository();
    }

    [HttpPost("/api/usuario")]
    public ActionResult<Usuario> Create(Usuario usuario)
    {
        _usuarioRepository.Create(usuario);
        return Ok(usuario);
    }

    [HttpPut("/api/usuario/{Id}/Nombre")]
    public  ActionResult<string> Update(int Id, Usuario usuario)
    {
        _usuarioRepository.Update(Id,usuario);
        return Ok("Actualizacion exitosa");

    }

    [HttpGet("/api/usuario/{Id}")]
    public  ActionResult<Usuario> GetUserById(int Id)
    {
        var usuario = _usuarioRepository.GetUsuarioById(Id);
        return Ok(usuario);
    }

    [HttpGet("/api/usuario")]
    public ActionResult<List<Usuario>> GetUsers()
    {
        var usuarios = _usuarioRepository.GetAllUsuarios();
        return Ok(usuarios);
    }

   /* [HttpDelete("/api/usuario/{Id}")]
    public ActionResult<bool> Delete(int Id)
    {
        return Ok( _usuarioRepository.DeleteUsuarioById(Id));
    }*/

}