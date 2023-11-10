using Microsoft.AspNetCore.Mvc;
using Models.Tarea;
using TareaRepositorio;

[ApiController]
[Route("[controller]")]
public class TareaController : ControllerBase
{
    private readonly ILogger<TareaController> _logger;
    private readonly TareaRepository _tareaRepository;

    public TareaController(ILogger<TareaController> logger)
    {
        _logger = logger;
        _tareaRepository = new TareaRepository();
    }

    [HttpPost("/api/tarea/{IdTablero}")]
    public ActionResult<Tarea> Create(int IdTablero, Tarea tarea)
    {
        _tareaRepository.Create(IdTablero, tarea);
        return Ok(tarea);
    }

    [HttpPut("/api/Tarea/{id}")]
    public ActionResult<bool> Update(int id, Tarea tarea)
    {
        return Ok(_tareaRepository.Update(id, tarea));
    }

    [HttpDelete("/api/Tarea/{id}")]
    public ActionResult<bool> Delete(int id)
    {
        return Ok(_tareaRepository.Delete(id));
    }

    [HttpGet("/api/Tarea/Usuario/{Id}")]
    public ActionResult<List<Tarea>> GetTareasByUser(int Id)
    {
        var tareas = _tareaRepository.GetTareasByUser(Id);
        return Ok(tareas);
    }

    [HttpGet("/api/Tarea/Tablero/{Id}")]
    public ActionResult<List<Tarea>> GetTareasByTablero(int Id)
    {
        var tareas = _tareaRepository.GetTareasByTablero(Id);
        return Ok(tareas);
    }

    [HttpPut("/api/Tarea/{idTarea}/Usuario/idUsuario")]
    public ActionResult<bool> AsignarUsuario(int idTarea, int idUsuario)
    {
        return Ok(_tareaRepository.AsignarUsuario(idTarea,idUsuario));
    }

    
}