using Infrastructure.Repo;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DatabaseController : ControllerBase
{
    private readonly IRepository _repository;

    public DatabaseController(IRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("structure")]
    public async Task<IActionResult> GetDatabaseStructure()
    {
        var structure = await _repository.GetDatabaseStructureAsync();
        return Ok(structure);
    }

    [HttpGet("tables")]
    public async Task<IActionResult> GetTablesStructure()
    {
        var tables = await _repository.GetTablesStructureAsync();
        return Ok(tables);
    }
}
