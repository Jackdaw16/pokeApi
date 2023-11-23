using System.ComponentModel.DataAnnotations.Schema;

namespace PkmApi.models;

public class Pokemon
{
    public int id { get; set; }
    [Column("id_pokedex")]
    public string idPokedex { get; set; }
    public string name { get; set; }
    public string img { get; set; }
}