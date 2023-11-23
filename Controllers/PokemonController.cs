using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PkmApi.Context;
using PkmApi.models;

namespace PkmApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{
    private readonly ILogger<PokemonController> _logger;
    private readonly ApplicationDatabaseContext _databaseContext;
    
    public PokemonController(ILogger<PokemonController> logger, ApplicationDatabaseContext databaseContext)
    {
        _logger = logger;
        _databaseContext = databaseContext;
    }

    [HttpGet(Name = "GetAllPokemons")]
    public async Task<ActionResult> GetAll()
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK, await _databaseContext.pokemons.ToListAsync());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(StatusCodes.Status500InternalServerError, e.Message); 
        }
    }
}