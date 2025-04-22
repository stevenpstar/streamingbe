namespace StreamingBE.Models;

public partial class Actor
{
    public int Actorid { get; set; }

    public string? Name { get; set; }

    public string? Picture { get; set; }

    public virtual ICollection<Moviecast> Moviecasts { get; set; } = new List<Moviecast>();
}
