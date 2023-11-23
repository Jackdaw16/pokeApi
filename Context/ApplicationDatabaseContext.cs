using Microsoft.EntityFrameworkCore;
using PkmApi.models;

namespace PkmApi.Context;

public class ApplicationDatabaseContext: DbContext
{

    public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
    {
    }

    public DbSet<Pokemon> pokemons { get; set; }
}