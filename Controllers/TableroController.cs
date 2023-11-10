using Microsoft.AspNetCore.Mvc;
using Models.Tablero;
using TableroRepositorio;

[ApiController]
[Route("[controller]")]
public class TableroController : ControllerBase
{
    private readonly ILogger<TableroController> _logger;
    private readonly TableroRepository _tableroRepository;

    public TableroController(ILogger<TableroController> logger)
    {
        _logger = logger;
        _tableroRepository = new TableroRepository();
    }

    [HttpPost("/api/tablero")]
    public ActionResult<Tablero> Create(Tablero tablero)
    {
        _tableroRepository.Create(tablero);
        return Ok(tablero);
    }

    [HttpGet("/api/tableros")]
    public ActionResult<List<Tablero>> GetTableros()
    {
        var tableros = _tableroRepository.GetTableros();
        return Ok(tableros);
    }

}